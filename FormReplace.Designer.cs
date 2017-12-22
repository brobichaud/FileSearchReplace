namespace FileSearchReplace
{
	partial class FormReplace
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
			this.lbActions = new System.Windows.Forms.ListBox();
			this.butClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbActions
			// 
			this.lbActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbActions.FormattingEnabled = true;
			this.lbActions.ItemHeight = 16;
			this.lbActions.Location = new System.Drawing.Point(16, 15);
			this.lbActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lbActions.Name = "lbActions";
			this.lbActions.Size = new System.Drawing.Size(661, 340);
			this.lbActions.TabIndex = 0;
			// 
			// butClose
			// 
			this.butClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butClose.Location = new System.Drawing.Point(579, 370);
			this.butClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.butClose.Name = "butClose";
			this.butClose.Size = new System.Drawing.Size(100, 28);
			this.butClose.TabIndex = 1;
			this.butClose.Text = "Close";
			this.butClose.UseVisualStyleBackColor = true;
			this.butClose.Click += new System.EventHandler(this.butClose_Click);
			// 
			// FormReplace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(695, 407);
			this.ControlBox = false;
			this.Controls.Add(this.butClose);
			this.Controls.Add(this.lbActions);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormReplace";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Replace Actions";
			this.Load += new System.EventHandler(this.FormReplace_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbActions;
		private System.Windows.Forms.Button butClose;
	}
}