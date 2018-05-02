namespace LinkChecker
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
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl404Counter = new System.Windows.Forms.Label();
			this.txt404 = new System.Windows.Forms.TextBox();
			this.lblCurrentCounter = new System.Windows.Forms.Label();
			this.lblTotalCounter = new System.Windows.Forms.Label();
			this.lbl404Results = new System.Windows.Forms.Label();
			this.cboSites = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSitemapUrl
			// 
			this.txtSitemapUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSitemapUrl.Location = new System.Drawing.Point(6, 80);
			this.txtSitemapUrl.Name = "txtSitemapUrl";
			this.txtSitemapUrl.Size = new System.Drawing.Size(588, 26);
			this.txtSitemapUrl.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Green;
			this.button1.Location = new System.Drawing.Point(241, 140);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(371, 33);
			this.button1.TabIndex = 2;
			this.button1.Text = "Check Links";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Green;
			this.label3.Location = new System.Drawing.Point(648, 342);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 20);
			this.label3.TabIndex = 6;
			// 
			// lbl404Counter
			// 
			this.lbl404Counter.BackColor = System.Drawing.SystemColors.Control;
			this.lbl404Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl404Counter.ForeColor = System.Drawing.Color.Red;
			this.lbl404Counter.Location = new System.Drawing.Point(6, 25);
			this.lbl404Counter.Name = "lbl404Counter";
			this.lbl404Counter.Size = new System.Drawing.Size(383, 28);
			this.lbl404Counter.TabIndex = 7;
			// 
			// txt404
			// 
			this.txt404.Location = new System.Drawing.Point(18, 178);
			this.txt404.Multiline = true;
			this.txt404.Name = "txt404";
			this.txt404.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt404.Size = new System.Drawing.Size(995, 305);
			this.txt404.TabIndex = 8;
			// 
			// lblCurrentCounter
			// 
			this.lblCurrentCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentCounter.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblCurrentCounter.Location = new System.Drawing.Point(6, 49);
			this.lblCurrentCounter.Name = "lblCurrentCounter";
			this.lblCurrentCounter.Size = new System.Drawing.Size(177, 62);
			this.lblCurrentCounter.TabIndex = 9;
			this.lblCurrentCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTotalCounter
			// 
			this.lblTotalCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalCounter.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.lblTotalCounter.Location = new System.Drawing.Point(183, 49);
			this.lblTotalCounter.Name = "lblTotalCounter";
			this.lblTotalCounter.Size = new System.Drawing.Size(206, 62);
			this.lblTotalCounter.TabIndex = 10;
			this.lblTotalCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl404Results
			// 
			this.lbl404Results.AutoSize = true;
			this.lbl404Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl404Results.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.lbl404Results.Location = new System.Drawing.Point(14, 150);
			this.lbl404Results.Name = "lbl404Results";
			this.lbl404Results.Size = new System.Drawing.Size(214, 20);
			this.lbl404Results.TabIndex = 11;
			this.lbl404Results.Text = "Files with 404 Responses";
			// 
			// cboSites
			// 
			this.cboSites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboSites.FormattingEnabled = true;
			this.cboSites.Location = new System.Drawing.Point(6, 25);
			this.cboSites.Name = "cboSites";
			this.cboSites.Size = new System.Drawing.Size(588, 28);
			this.cboSites.TabIndex = 12;
			this.cboSites.SelectedIndexChanged += new System.EventHandler(this.cboSites_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cboSites);
			this.groupBox1.Controls.Add(this.txtSitemapUrl);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(600, 122);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Choose a Sitemap URL to Process";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 17);
			this.label1.TabIndex = 13;
			this.label1.Text = "OR enter a valid sitemap URL below:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lbl404Counter);
			this.groupBox2.Controls.Add(this.lblCurrentCounter);
			this.groupBox2.Controls.Add(this.lblTotalCounter);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(618, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(395, 122);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Status";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1020, 492);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lbl404Results);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt404);
			this.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Name = "Form1";
			this.Text = "Sitemap 404 Checker";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSitemapUrl;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl404Counter;
		private System.Windows.Forms.TextBox txt404;
		private System.Windows.Forms.Label lblCurrentCounter;
		private System.Windows.Forms.Label lblTotalCounter;
		private System.Windows.Forms.Label lbl404Results;
		private System.Windows.Forms.ComboBox cboSites;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}

