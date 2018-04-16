using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace LinkChecker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtSitemapUrl.TextLength == 0 || txtSitemapUrl.Text == "https://")
			{
				MessageBox.Show("Please provide a valid sitemap URL.");
			}
			else
			{
				var sb = new StringBuilder();
				var web = new HtmlWeb();
				var htmlDoc = web.Load(txtSitemapUrl.Text);
				var links = htmlDoc.DocumentNode.SelectNodes("//div[contains(@id,'cphMain_dataDiv')]//a");

				foreach(var link in links)
				{
					sb.Append(link.Attributes["href"].Value + Environment.NewLine);
				}

				txtResults.Text = sb.ToString();
			}
		}
	}
}
