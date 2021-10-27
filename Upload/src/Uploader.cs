using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.IO;

namespace Upload
{
	class Uploader
	{
		private string user;
		private string password;

		public Uploader()
		{
			ReadCredentials();
		}

		private void ReadCredentials()
		{
			var contents = File.ReadAllLines("Credentials");
			user = contents[0];
			password = contents[1];
		}

		public void UploadSchuelerToFtp(string file)
		{
			DeleteFile(uri: new Uri("ftp://whgonline.de/vplan_a.pdf"));
			RenameFile(uri: new Uri("ftp://whgonline.de/vplan.pdf"), newName: new Uri("ftp://whgonline.de/vplan_a.pdf"));
			UploadFile(uri: new Uri("ftp://whgonline.de/vplan.pdf"), file: file);
			Get("https://whgonline.de/vplan/pdf2png.php");
		}

		public void UploadLehrerToFtp(string file)
		{
			DeleteFile(uri: new Uri("ftp://whgonline.de/vplanL.pdf"));
			UploadFile(uri: new Uri("ftp://whgonline.de/vplanL.pdf"), file: file);
			Get("https://whgonline.de/vplan/pdf2png.php");
		}

		private void DeleteFile(Uri uri)
		{
			try
			{
				if (uri.Scheme != Uri.UriSchemeFtp)
				{
					MessageBox.Show("Der angegebene FTP Pfad ist falsch");
				}
				FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
				request.Credentials = new NetworkCredential(user, password);
				request.Method = WebRequestMethods.Ftp.DeleteFile;
				request.Proxy = null;

				FtpWebResponse response = (FtpWebResponse)request.GetResponse();
				//MessageBox.Show($"Delete status: {response.StatusDescription}");
				response.Close();
				
			}
			catch (Exception)
			{
				MessageBox.Show("Es gab einen Fehler beim Löschen einer Datei");
			}
		}

		private void UploadFile(Uri uri, string file)
		{
			try
			{
				if (uri.Scheme != Uri.UriSchemeFtp)
				{
					MessageBox.Show("Der angegebene FTP Pfad ist falsch");
				}
				FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
				request.Credentials = new NetworkCredential(user, password);
				request.Method = WebRequestMethods.Ftp.UploadFile;
				request.Proxy = null;

				using (FileStream fs = File.OpenRead(file))
				{
					byte[] buffer = new byte[fs.Length];
					//Liest alle Bytes aus dem PDF in den Buffer
					fs.Read(buffer, 0, buffer.Length);
					fs.Close();
					Stream requestStream = request.GetRequestStream();
					//Schreibt die Bytes aus dem Buffer in den Request Stream, der dann die Daten überträgt
					requestStream.Write(buffer, 0, buffer.Length);
					requestStream.Flush();
					requestStream.Close();
				}

				FtpWebResponse response = (FtpWebResponse)request.GetResponse();
				//MessageBox.Show($"Upload status: {response.StatusDescription}");
				response.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Es gab einen Fehler beim Uploaden einer Datei");
			}
		}

		private void RenameFile(Uri uri, Uri newName)
		{

			FtpWebRequest ftpRequest;
			WebClient request;
			Stream requestStream;
			byte[] buffer;

			ftpRequest = (FtpWebRequest)WebRequest.Create(newName);
			ftpRequest.Credentials = new NetworkCredential(user, password);
			ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
			ftpRequest.Proxy = null;

            request = new WebClient
            {
                Credentials = new NetworkCredential(user, password)
            };

            try
			{
				//Daten der Datei in den Buffer herunterladen
				buffer = request.DownloadData(uri);
				requestStream = ftpRequest.GetRequestStream();
				//Neue Datei hochladen mit aktualisiertem Namen
				requestStream.Write(buffer, 0, buffer.Length);
				requestStream.Flush();
				requestStream.Close();

			}
			catch (WebException)
			{
				MessageBox.Show("Es gab einen Fehler beim Umbenennen der Datei");
			}

			//Datei mit altem Namen löschen
			DeleteFile(uri);
		}

		private async void Get(string url)
		{
			using (HttpClient client = new HttpClient())
			{
				using (HttpResponseMessage response = await client.GetAsync(url))
				{
					if (response.IsSuccessStatusCode == false)
						MessageBox.Show("Fehler beim Hochladen der Dateien");
				}
			}
		}

	}
}

