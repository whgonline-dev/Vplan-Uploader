using System;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Upload
{
	public partial class UploadForm : Form
	{
		private readonly Uploader ul = new Uploader();

		private static string studentFile = string.Empty;
		private static string teacherFile = string.Empty;
		

		public UploadForm()
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
				studentFile = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
				schueler.BackgroundImage = Properties.Resources.Pdf;
				schueler_file_txtbox.Text = studentFile.Split('\\').Last();
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
				teacherFile = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
				lehrer.BackgroundImage = Properties.Resources.Pdf;
				lehrer_file_txtbox.Text = teacherFile.Split('\\').Last();

			}
			else
				MessageBox.Show("Falsche Datei, es muss eine PDF hochgeladen werden");
		}

		private void clear_schueler_Click(object sender, EventArgs e)
		{
			if (studentFile != string.Empty)
			{
				studentFile = string.Empty;
				schueler.BackgroundImage = Properties.Resources.Schüler;
				schueler_file_txtbox.Text = string.Empty;
			}
		}

		private void clear_lehrer_Click(object sender, EventArgs e)
		{
			if (teacherFile != string.Empty)
			{
				teacherFile = string.Empty;
				lehrer.BackgroundImage = Properties.Resources.Lehrer;
				lehrer_file_txtbox.Text = string.Empty;
			}
		}

		private void upload_schueler_btn_Click(object sender, EventArgs e)
		{
			if (studentFile != string.Empty)
			{
				ul.UploadSchuelerToFtp(studentFile);
				schueler.BackgroundImage = Properties.Resources.Schüler;
				studentFile = string.Empty;
				schueler_file_txtbox.Text = string.Empty;
				
			}
			else
				MessageBox.Show("Keine Datei zum Hochladen gefunden");
		}

		private void upload_lehrer_btn_Click(object sender, EventArgs e)
		{
			if (teacherFile != string.Empty)
			{
				ul.UploadLehrerToFtp(teacherFile);
				lehrer.BackgroundImage = Properties.Resources.Lehrer;
				teacherFile = string.Empty;
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
			studentFile = openFileDialog1.FileName;
			if (studentFile != string.Empty)
			{
				schueler_file_txtbox.Text = studentFile.Split('\\').Last();
				schueler.BackgroundImage = Properties.Resources.Pdf;
			}
		}

		private void Browse_Lehrer_Click(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\Documents";
			openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf";
			openFileDialog1.FileName = string.Empty;
			openFileDialog1.ShowDialog();
			teacherFile = openFileDialog1.FileName;
			if (teacherFile != string.Empty)
			{
				lehrer_file_txtbox.Text = teacherFile.Split('\\').Last();
				lehrer.BackgroundImage = Properties.Resources.Pdf;
			}
		}

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
			new AboutForm(this.DesktopLocation, this.Size).Show();
        }
    }
}
