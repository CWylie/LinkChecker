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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txt404 = new System.Windows.Forms.TextBox();
			this.txtSuccess = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSitemapUrl
			// 
			this.txtSitemapUrl.Location = new System.Drawing.Point(12, 39);
			this.txtSitemapUrl.Name = "txtSitemapUrl";
			this.txtSitemapUrl.Size = new System.Drawing.Size(691, 20);
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
			this.button1.Location = new System.Drawing.Point(12, 65);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(321, 42);
			this.button1.TabIndex = 2;
			this.button1.Text = "Check Links";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblCounter
			// 
			this.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCounter.ForeColor = System.Drawing.Color.Green;
			this.lblCounter.Location = new System.Drawing.Point(349, 65);
			this.lblCounter.Name = "lblCounter";
			this.lblCounter.Size = new System.Drawing.Size(354, 42);
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
			this.lbl404Counter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl404Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl404Counter.ForeColor = System.Drawing.Color.Red;
			this.lbl404Counter.Location = new System.Drawing.Point(349, 112);
			this.lbl404Counter.Name = "lbl404Counter";
			this.lbl404Counter.Size = new System.Drawing.Size(354, 38);
			this.lbl404Counter.TabIndex = 7;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(12, 153);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1264, 551);
			this.tabControl1.TabIndex = 8;
			// 
			// tabPage1
			// 
			this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPage1.Controls.Add(this.txt404);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1256, 518);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "404 Responses";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabPage2.Controls.Add(this.txtSuccess);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1256, 525);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Successful Responses";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txt404
			// 
			this.txt404.Location = new System.Drawing.Point(3, 2);
			this.txt404.Multiline = true;
			this.txt404.Name = "txt404";
			this.txt404.Size = new System.Drawing.Size(1251, 521);
			this.txt404.TabIndex = 0;
			// 
			// txtSuccess
			// 
			this.txtSuccess.Location = new System.Drawing.Point(2, 0);
			this.txtSuccess.Multiline = true;
			this.txtSuccess.Name = "txtSuccess";
			this.txtSuccess.Size = new System.Drawing.Size(1252, 523);
			this.txtSuccess.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1296, 704);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.lbl404Counter);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblCounter);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSitemapUrl);
			this.Name = "Form1";
			this.Text = "Sitemap 404 Checker";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
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
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox txt404;
		private System.Windows.Forms.TextBox txtSuccess;
	}
}

