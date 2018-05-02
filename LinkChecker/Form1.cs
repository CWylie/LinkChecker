using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;
using System.ComponentModel;

namespace LinkChecker
{
	public partial class Form1 : Form
	{
		private StringBuilder _sb = new StringBuilder();
		private int _overallCounter;
		private int _404Counter;
		private int _successCounter;
		private int _currentCounter;

		public Form1()
		{
			InitializeComponent();

			InitializeComboBox();
		}

		BindingList<site> listOfSites;
		private void InitializeComboBox()
		{
			List<site> sites = ConfigurationManager.GetSection("siteList") as List<site>;
			sites.Sort((x, y) => string.Compare(x.displayName, y.displayName));
			sites.Insert(0, new site { displayName="- Choose a Site -", url="" });
			listOfSites = new BindingList<site>(sites);
			cboSites.DataSource = listOfSites;
			cboSites.ValueMember = "url";
			cboSites.DisplayMember = "displayName";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtSitemapUrl.TextLength == 0 && string.IsNullOrEmpty(cboSites.SelectedValue.ToString()))
			{

				MessageBox.Show("Please choose a site from the drop-down or provide a valid sitemap URL.");
			}
			else
			{
				var siteUrl = txtSitemapUrl.TextLength > 0 ? txtSitemapUrl.Text : cboSites.SelectedValue.ToString();
				var web = new HtmlWeb();
				var htmlDoc = web.Load(siteUrl);
				var links = htmlDoc.DocumentNode.SelectNodes("//div[contains(@id,'cphMain_dataDiv')]//a");
				var linkList = new List<string>();

				_overallCounter = 0;
				_404Counter = 0;
				_successCounter = 0;
				_currentCounter = 0;
				txt404.Text = string.Empty;
				lbl404Counter.Text = string.Empty;
				lblCurrentCounter.Text = string.Empty;
				lblTotalCounter.Text = string.Empty;
				button1.Enabled = false;

				foreach(var link in links)
				{
					_overallCounter++;
					linkList.Add(link.Attributes["href"].Value);
				}

				_currentCounter = _overallCounter;
				lblCurrentCounter.Text = _currentCounter.ToString();
				lblTotalCounter.Text = "/ " + _overallCounter.ToString();

				CheckUrls(linkList);
			}
		}

		private async void CheckUrls(List<string> linkList)
		{
			foreach (var link in linkList)
			{
				await CheckUrl(link);
			}

			txt404.Text = _sb.ToString();
			button1.Enabled = true;
		}

		private async Task CheckUrl(string link)
		{
			using (var client = new HttpClient())
			{
				var response = new HttpResponseMessage();

				try
				{
					response = await client.GetAsync(link);
				}
				catch(HttpRequestException e)
				{
					link = link + " (Uncaught Error)";
					response = null;
				}

				_currentCounter--;
				lblCurrentCounter.Text = _currentCounter.ToString();

				if (response != null && response.IsSuccessStatusCode)
					_successCounter++;
				else
				{
					_sb.Append(link + Environment.NewLine + Environment.NewLine);
					_404Counter++;

					if (_404Counter == 1)
						lbl404Counter.Text = "1 file with 404 error found";
					else
						lbl404Counter.Text = _404Counter.ToString() + " files with 404 errors found";
				}
			}
		}

		private void cboSites_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(cboSites.SelectedValue.ToString()))
				txtSitemapUrl.Text = string.Empty;
		}
	}

	public class SiteListSection : IConfigurationSectionHandler
	{
		public object Create(object parent, object configContext, XmlNode section)
		{
			List<site> myConfigObject = new List<site>();

			foreach(XmlNode childNode in section.ChildNodes)
			{
				var site = new site();

				foreach (XmlAttribute attrib in childNode.Attributes)
				{
					switch (attrib.Name)
					{
						case "instance":
							site.instance = attrib.Value;
							break;
						case "url":
							site.url = attrib.Value;
							break;
						case "displayName":
							site.displayName = attrib.Value;
							break;
						case "active":
							site.active = attrib.Value.ToLower().Equals("true");
							break;
						default:
							break;
					}
				}

				if(site.active)
					myConfigObject.Add(site);
			}
			return myConfigObject;
		}
	}

	public class site
	{
		public string instance { get; set; }
		public string url { get; set; }
		public string displayName { get; set; }
		public bool active { get; set; }
	}
}
