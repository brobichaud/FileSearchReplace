using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Digimarc.Shared.Classes;

namespace FileSearchReplace
{
	public partial class FormMain : Form
	{
		private const string SettingsFile = "settings.xml";

		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			if (File.Exists(SettingsFile))
			{
				var doc = XElement.Load(SettingsFile);
				txFolder.Text = (string)doc.Element("Folder");
				txTypes.Text = (string)doc.Element("Types");
				txFind.Text = (string)doc.Element("FindText");
				txReplace.Text = (string)doc.Element("ReplaceText");
			}
		}

		private void FormMain_Shown(object sender, EventArgs e)
		{
			txFind.Focus();
		}

		private void butClose_Click(object sender, EventArgs e)
		{
			var settings = new Settings
			{
				Folder = txFolder.Text,
				Types = txTypes.Text,
				FindText = txFind.Text,
				ReplaceText = txReplace.Text
			};

			var xml = new XmlIO { FormatData = true };
			xml.Serialize(settings, SettingsFile);
			
			Close();
		}

		private void butBrowse_Click(object sender, EventArgs e)
		{
			var dlg = new FolderBrowserDialog
			{
				Description = @"Select Folder to Operate On",
				SelectedPath = txFolder.Text
			};

			if (dlg.ShowDialog() == DialogResult.OK)
				txFolder.Text = dlg.SelectedPath;
		}

		private void butReplace_Click(object sender, EventArgs e)
		{
			var settings = new Settings
			{
				Folder = txFolder.Text,
				Types = txTypes.Text,
				FindText = txFind.Text,
				ReplaceText = txReplace.Text
			};

			var dlg = new FormReplace();
			dlg.Start(settings);
			dlg.ShowDialog();
		}
	}
}
