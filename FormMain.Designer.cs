namespace FileSearchReplace
{
	partial class FormMain
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
			this.lbFolder = new System.Windows.Forms.Label();
			this.txFolder = new System.Windows.Forms.TextBox();
			this.lbFind = new System.Windows.Forms.Label();
			this.txFind = new System.Windows.Forms.TextBox();
			this.lbReplace = new System.Windows.Forms.Label();
			this.txReplace = new System.Windows.Forms.TextBox();
			this.butBrowse = new System.Windows.Forms.Button();
			this.butReplace = new System.Windows.Forms.Button();
			this.butClose = new System.Windows.Forms.Button();
			this.lbTypes = new System.Windows.Forms.Label();
			this.txTypes = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbFolder
			// 
			this.lbFolder.AutoSize = true;
			this.lbFolder.Location = new System.Drawing.Point(60, 32);
			this.lbFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbFolder.Name = "lbFolder";
			this.lbFolder.Size = new System.Drawing.Size(52, 17);
			this.lbFolder.TabIndex = 0;
			this.lbFolder.Text = "Folder:";
			// 
			// txFolder
			// 
			this.txFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txFolder.Location = new System.Drawing.Point(115, 28);
			this.txFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txFolder.Name = "txFolder";
			this.txFolder.Size = new System.Drawing.Size(571, 22);
			this.txFolder.TabIndex = 1;
			// 
			// lbFind
			// 
			this.lbFind.AutoSize = true;
			this.lbFind.Location = new System.Drawing.Point(24, 100);
			this.lbFind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbFind.Name = "lbFind";
			this.lbFind.Size = new System.Drawing.Size(86, 17);
			this.lbFind.TabIndex = 5;
			this.lbFind.Text = "Text to Find:";
			// 
			// txFind
			// 
			this.txFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txFind.Location = new System.Drawing.Point(115, 96);
			this.txFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txFind.Name = "txFind";
			this.txFind.Size = new System.Drawing.Size(571, 22);
			this.txFind.TabIndex = 6;
			// 
			// lbReplace
			// 
			this.lbReplace.AutoSize = true;
			this.lbReplace.Location = new System.Drawing.Point(12, 133);
			this.lbReplace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbReplace.Name = "lbReplace";
			this.lbReplace.Size = new System.Drawing.Size(96, 17);
			this.lbReplace.TabIndex = 7;
			this.lbReplace.Text = "Replace With:";
			// 
			// txReplace
			// 
			this.txReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txReplace.Location = new System.Drawing.Point(115, 129);
			this.txReplace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txReplace.Name = "txReplace";
			this.txReplace.Size = new System.Drawing.Size(571, 22);
			this.txReplace.TabIndex = 8;
			// 
			// butBrowse
			// 
			this.butBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.butBrowse.Location = new System.Drawing.Point(695, 26);
			this.butBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.butBrowse.Name = "butBrowse";
			this.butBrowse.Size = new System.Drawing.Size(35, 28);
			this.butBrowse.TabIndex = 2;
			this.butBrowse.Text = "...";
			this.butBrowse.UseVisualStyleBackColor = true;
			this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
			// 
			// butReplace
			// 
			this.butReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butReplace.Location = new System.Drawing.Point(523, 169);
			this.butReplace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.butReplace.Name = "butReplace";
			this.butReplace.Size = new System.Drawing.Size(100, 28);
			this.butReplace.TabIndex = 9;
			this.butReplace.Text = "Replace...";
			this.butReplace.UseVisualStyleBackColor = true;
			this.butReplace.Click += new System.EventHandler(this.butReplace_Click);
			// 
			// butClose
			// 
			this.butClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butClose.Location = new System.Drawing.Point(630, 169);
			this.butClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.butClose.Name = "butClose";
			this.butClose.Size = new System.Drawing.Size(100, 28);
			this.butClose.TabIndex = 10;
			this.butClose.Text = "Close";
			this.butClose.UseVisualStyleBackColor = true;
			this.butClose.Click += new System.EventHandler(this.butClose_Click);
			// 
			// lbTypes
			// 
			this.lbTypes.AutoSize = true;
			this.lbTypes.Location = new System.Drawing.Point(35, 68);
			this.lbTypes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbTypes.Name = "lbTypes";
			this.lbTypes.Size = new System.Drawing.Size(77, 17);
			this.lbTypes.TabIndex = 3;
			this.lbTypes.Text = "File Types:";
			// 
			// txTypes
			// 
			this.txTypes.Location = new System.Drawing.Point(115, 62);
			this.txTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txTypes.Name = "txTypes";
			this.txTypes.Size = new System.Drawing.Size(132, 22);
			this.txTypes.TabIndex = 4;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(745, 215);
			this.ControlBox = false;
			this.Controls.Add(this.txTypes);
			this.Controls.Add(this.lbTypes);
			this.Controls.Add(this.butClose);
			this.Controls.Add(this.butReplace);
			this.Controls.Add(this.butBrowse);
			this.Controls.Add(this.txReplace);
			this.Controls.Add(this.lbReplace);
			this.Controls.Add(this.txFind);
			this.Controls.Add(this.lbFind);
			this.Controls.Add(this.txFolder);
			this.Controls.Add(this.lbFolder);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1359, 302);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(763, 262);
			this.Name = "FormMain";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "File Search and Replace";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.Shown += new System.EventHandler(this.FormMain_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbFolder;
		private System.Windows.Forms.TextBox txFolder;
		private System.Windows.Forms.Label lbFind;
		private System.Windows.Forms.TextBox txFind;
		private System.Windows.Forms.Label lbReplace;
		private System.Windows.Forms.TextBox txReplace;
		private System.Windows.Forms.Button butBrowse;
		private System.Windows.Forms.Button butReplace;
		private System.Windows.Forms.Button butClose;
		private System.Windows.Forms.Label lbTypes;
		private System.Windows.Forms.TextBox txTypes;
	}
}

