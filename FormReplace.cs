using System;
using System.IO;
using System.Windows.Forms;

namespace FileSearchReplace
{
	public partial class FormReplace : Form
	{
		private Settings Settings;

		public FormReplace()
		{
			InitializeComponent();
		}

		private void butClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		public void Start(Settings settings)
		{
			Settings = settings;
		}

		private void FormReplace_Load(object sender, EventArgs e)
		{
			butClose.Enabled = false;

			foreach (var file in Directory.GetFiles(Settings.Folder, Settings.Types))
			{
				string text = File.ReadAllText(file);
				string newText = text.Replace(Settings.FindText, Settings.ReplaceText);

				if (string.CompareOrdinal(text, newText) != 0)
				{
					lbActions.Items.Add(Path.GetFileName(file));
					File.WriteAllText(file, newText);
				}
			}

			butClose.Enabled = true;
		}
	}
}
