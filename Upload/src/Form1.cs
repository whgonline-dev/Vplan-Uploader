using System;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace Upload
{
	public partial class Form1 : Form
	{

		private Uploader ul = new Uploader();

		private static string file_schueler = string.Empty;
		private static string file_lehrer = string.Empty;
		

		public Form1()
		{
			InitializeComponent();
		}

		private void schueler_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}

		private void schueler_DragDrop(object sender, DragEventArgs e)
		{
			if (Path.GetExtension(((string[])e.Data.GetData(DataFormats.FileDrop))[0]) == ".pdf")
			{
				file_schueler = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
				schueler.BackgroundImage = Properties.Resources.pdf_png;
				schueler_file_txtbox.Text = file_schueler.Split('\\').Last();
			}
			else
				MessageBox.Show("Falsche Datei, es muss eine PDF hochgeladen werden");
		}

		private void lehrer_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}

		private void lehrer_DragDrop(object sender, DragEventArgs e)
		{
			if (Path.GetExtension(((string[])e.Data.GetData(DataFormats.FileDrop))[0]) == ".pdf")
			{
				file_lehrer = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
				lehrer.BackgroundImage = Properties.Resources.pdf_png;
				lehrer_file_txtbox.Text = file_lehrer.Split('\\').Last();

			}
			else
				MessageBox.Show("Falsche Datei, es muss eine PDF hochgeladen werden");
		}

		private void clear_schueler_Click(object sender, EventArgs e)
		{
			if (file_schueler != string.Empty)
			{
				file_schueler = string.Empty;
				schueler.BackgroundImage = Properties.Resources.schueler_png;
				schueler_file_txtbox.Text = string.Empty;
			}
		}

		private void clear_lehrer_Click(object sender, EventArgs e)
		{
			if (file_lehrer != string.Empty)
			{
				file_lehrer = string.Empty;
				lehrer.BackgroundImage = Properties.Resources.lehrer_png;
				lehrer_file_txtbox.Text = string.Empty;
			}
		}

		private void upload_schueler_btn_Click(object sender, EventArgs e)
		{
			if (file_schueler != string.Empty)
			{
				ul.UploadSchuelerToFtp(file_schueler);
				schueler.BackgroundImage = Properties.Resources.schueler_png;
				file_schueler = string.Empty;
				schueler_file_txtbox.Text = string.Empty;
				
			}
			else
				MessageBox.Show("Keine Datei zum Hochladen gefunden");
		}

		private void upload_lehrer_btn_Click(object sender, EventArgs e)
		{
			if (file_lehrer != string.Empty)
			{
				ul.UploadLehrerToFtp(file_lehrer);
				lehrer.BackgroundImage = Properties.Resources.lehrer_png;
				file_lehrer = string.Empty;
				lehrer_file_txtbox.Text = string.Empty;
			}
			else
				MessageBox.Show("Keine Datei zum Hochladen gefunden");
		}

		private void Browse_Schueler_Click(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Documents";
			openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf";
			openFileDialog1.FileName = string.Empty;
			openFileDialog1.ShowDialog();
			file_schueler = openFileDialog1.FileName;
			if (file_schueler != string.Empty)
			{
				schueler_file_txtbox.Text = file_schueler.Split('\\').Last();
				schueler.BackgroundImage = Properties.Resources.pdf_png;
			}
		}

		private void Browse_Lehrer_Click(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Documents";
			openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf";
			openFileDialog1.FileName = string.Empty;
			openFileDialog1.ShowDialog();
			file_lehrer = openFileDialog1.FileName;
			if (file_lehrer != string.Empty)
			{
				lehrer_file_txtbox.Text = file_lehrer.Split('\\').Last();
				lehrer.BackgroundImage = Properties.Resources.pdf_png;
			}
		}
	}
}
