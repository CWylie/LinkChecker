﻿namespace LinkChecker
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtSitemapUrl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txtResults = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtSitemapUrl
			// 
			this.txtSitemapUrl.Location = new System.Drawing.Point(12, 29);
			this.txtSitemapUrl.Name = "txtSitemapUrl";
			this.txtSitemapUrl.Size = new System.Drawing.Size(691, 20);
			this.txtSitemapUrl.TabIndex = 0;
			this.txtSitemapUrl.Text = "https://";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Sitemap URL";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(14, 65);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(321, 42);
			this.button1.TabIndex = 2;
			this.button1.Text = "Check Links";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtResults
			// 
			this.txtResults.Location = new System.Drawing.Point(17, 144);
			this.txtResults.Multiline = true;
			this.txtResults.Name = "txtResults";
			this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtResults.Size = new System.Drawing.Size(1267, 548);
			this.txtResults.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "404 Responses";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1296, 704);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtResults);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSitemapUrl);
			this.Name = "Form1";
			this.Text = "Sitemap 404 Checker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSitemapUrl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtResults;
		private System.Windows.Forms.Label label2;
	}
}

