using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace LinkChecker
{
	public partial class Form1 : Form
	{
		private StringBuilder _sb = new StringBuilder();
		private int _overallCounter;
		private int _404Counter;
		private int _successCounter;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtSitemapUrl.TextLength == 0)
			{
				MessageBox.Show("Please provide a valid sitemap URL.");
			}
			else
			{
				var web = new HtmlWeb();
				var htmlDoc = web.Load(txtSitemapUrl.Text);
				var links = htmlDoc.DocumentNode.SelectNodes("//div[contains(@id,'cphMain_dataDiv')]//a");
				var linkList = new List<string>();

				_overallCounter = 0;
				_404Counter = 0;
				_successCounter = 0;
				txt404.Text = string.Empty;

				button1.Enabled = false;

				foreach(var link in links)
				{
					_overallCounter++;
					linkList.Add(link.Attributes["href"].Value);
				}

				if(_overallCounter==1)
					lblCounter.Text = "Processing 1 link...";
				else
					lblCounter.Text = "Processing " + _overallCounter.ToString() + " links...";

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
			lblCounter.Text = "Processing Completed Successfully!!";
			button1.Enabled = true;
		}

		private async Task CheckUrl(string link)
		{
			using (var client = new HttpClient())
			{
				var response = await client.GetAsync(link);

				if (response.IsSuccessStatusCode)
					_successCounter++;
				else
				{
					_sb.Append(link + Environment.NewLine);
					_404Counter++;

					if(_404Counter == 1)
						lbl404Counter.Text = "1 file with 404 error found";
					else
						lbl404Counter.Text = _404Counter.ToString() + " files with 404 errors found";
				}
			}
		}
	}
}
