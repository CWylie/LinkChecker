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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lblCounter = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl404Counter = new System.Windows.Forms.Label();
			this.txt404 = new System.Windows.Forms.TextBox();
			this.lblCurrentCounter = new System.Windows.Forms.Label();
			this.lblTotalCounter = new System.Windows.Forms.Label();
			this.lbl404Results = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtSitemapUrl
			// 
			this.txtSitemapUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSitemapUrl.Location = new System.Drawing.Point(16, 39);
			this.txtSitemapUrl.Name = "txtSitemapUrl";
			this.txtSitemapUrl.Size = new System.Drawing.Size(321, 26);
			this.txtSitemapUrl.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Sitemap URL";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(16, 74);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(321, 33);
			this.button1.TabIndex = 2;
			this.button1.Text = "Check Links";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblCounter
			// 
			this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCounter.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblCounter.Location = new System.Drawing.Point(349, 39);
			this.lblCounter.Name = "lblCounter";
			this.lblCounter.Size = new System.Drawing.Size(275, 42);
			this.lblCounter.TabIndex = 5;
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
			this.lbl404Counter.Location = new System.Drawing.Point(349, 96);
			this.lbl404Counter.Name = "lbl404Counter";
			this.lbl404Counter.Size = new System.Drawing.Size(275, 38);
			this.lbl404Counter.TabIndex = 7;
			// 
			// txt404
			// 
			this.txt404.Location = new System.Drawing.Point(16, 152);
			this.txt404.Multiline = true;
			this.txt404.Name = "txt404";
			this.txt404.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt404.Size = new System.Drawing.Size(1255, 531);
			this.txt404.TabIndex = 8;
			// 
			// lblCurrentCounter
			// 
			this.lblCurrentCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentCounter.ForeColor = System.Drawing.Color.SteelBlue;
			this.lblCurrentCounter.Location = new System.Drawing.Point(636, 23);
			this.lblCurrentCounter.Name = "lblCurrentCounter";
			this.lblCurrentCounter.Size = new System.Drawing.Size(260, 111);
			this.lblCurrentCounter.TabIndex = 9;
			this.lblCurrentCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTotalCounter
			// 
			this.lblTotalCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalCounter.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.lblTotalCounter.Location = new System.Drawing.Point(878, 23);
			this.lblTotalCounter.Name = "lblTotalCounter";
			this.lblTotalCounter.Size = new System.Drawing.Size(393, 111);
			this.lblTotalCounter.TabIndex = 10;
			this.lblTotalCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl404Results
			// 
			this.lbl404Results.AutoSize = true;
			this.lbl404Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl404Results.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.lbl404Results.Location = new System.Drawing.Point(12, 129);
			this.lbl404Results.Name = "lbl404Results";
			this.lbl404Results.Size = new System.Drawing.Size(214, 20);
			this.lbl404Results.TabIndex = 11;
			this.lbl404Results.Text = "Files with 404 Responses";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1296, 704);
			this.Controls.Add(this.lbl404Results);
			this.Controls.Add(this.lblTotalCounter);
			this.Controls.Add(this.lblCurrentCounter);
			this.Controls.Add(this.txt404);
			this.Controls.Add(this.lbl404Counter);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblCounter);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSitemapUrl);
			this.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.Name = "Form1";
			this.Text = "Sitemap 404 Checker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSitemapUrl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblCounter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl404Counter;
		private System.Windows.Forms.TextBox txt404;
		private System.Windows.Forms.Label lblCurrentCounter;
		private System.Windows.Forms.Label lblTotalCounter;
		private System.Windows.Forms.Label lbl404Results;
	}
}

