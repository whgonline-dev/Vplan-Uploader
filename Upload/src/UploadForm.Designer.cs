namespace Upload
{
	partial class UploadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadForm));
            this.upload_schueler_btn = new System.Windows.Forms.Button();
            this.schueler_file_txtbox = new System.Windows.Forms.TextBox();
            this.lehrer_file_txtbox = new System.Windows.Forms.TextBox();
            this.upload_lehrer_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Browse_Lehrer = new System.Windows.Forms.Button();
            this.Browse_Schueler = new System.Windows.Forms.Button();
            this.clear_schueler = new System.Windows.Forms.Button();
            this.clear_lehrer = new System.Windows.Forms.Button();
            this.lehrer = new System.Windows.Forms.Panel();
            this.schueler = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // upload_schueler_btn
            // 
            this.upload_schueler_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.upload_schueler_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_schueler_btn.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_schueler_btn.ForeColor = System.Drawing.Color.White;
            this.upload_schueler_btn.Location = new System.Drawing.Point(100, 350);
            this.upload_schueler_btn.Name = "upload_schueler_btn";
            this.upload_schueler_btn.Size = new System.Drawing.Size(150, 50);
            this.upload_schueler_btn.TabIndex = 5;
            this.upload_schueler_btn.Text = "Upload Schüler";
            this.upload_schueler_btn.UseVisualStyleBackColor = false;
            this.upload_schueler_btn.Click += new System.EventHandler(this.upload_schueler_btn_Click);
            // 
            // schueler_file_txtbox
            // 
            this.schueler_file_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.schueler_file_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schueler_file_txtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.schueler_file_txtbox.Enabled = false;
            this.schueler_file_txtbox.Location = new System.Drawing.Point(50, 196);
            this.schueler_file_txtbox.Name = "schueler_file_txtbox";
            this.schueler_file_txtbox.ReadOnly = true;
            this.schueler_file_txtbox.Size = new System.Drawing.Size(240, 20);
            this.schueler_file_txtbox.TabIndex = 6;
            this.schueler_file_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lehrer_file_txtbox
            // 
            this.lehrer_file_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lehrer_file_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lehrer_file_txtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.lehrer_file_txtbox.Enabled = false;
            this.lehrer_file_txtbox.Location = new System.Drawing.Point(450, 196);
            this.lehrer_file_txtbox.Name = "lehrer_file_txtbox";
            this.lehrer_file_txtbox.ReadOnly = true;
            this.lehrer_file_txtbox.Size = new System.Drawing.Size(240, 20);
            this.lehrer_file_txtbox.TabIndex = 7;
            this.lehrer_file_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // upload_lehrer_btn
            // 
            this.upload_lehrer_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.upload_lehrer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_lehrer_btn.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_lehrer_btn.ForeColor = System.Drawing.Color.White;
            this.upload_lehrer_btn.Location = new System.Drawing.Point(495, 350);
            this.upload_lehrer_btn.Name = "upload_lehrer_btn";
            this.upload_lehrer_btn.Size = new System.Drawing.Size(150, 50);
            this.upload_lehrer_btn.TabIndex = 8;
            this.upload_lehrer_btn.Text = "Upload Lehrer";
            this.upload_lehrer_btn.UseVisualStyleBackColor = false;
            this.upload_lehrer_btn.Click += new System.EventHandler(this.upload_lehrer_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Browse_Lehrer
            // 
            this.Browse_Lehrer.BackgroundImage = global::Upload.Properties.Resources.Explorer;
            this.Browse_Lehrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Browse_Lehrer.FlatAppearance.BorderSize = 0;
            this.Browse_Lehrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse_Lehrer.Location = new System.Drawing.Point(407, 186);
            this.Browse_Lehrer.Name = "Browse_Lehrer";
            this.Browse_Lehrer.Size = new System.Drawing.Size(35, 35);
            this.Browse_Lehrer.TabIndex = 10;
            this.Browse_Lehrer.UseVisualStyleBackColor = true;
            this.Browse_Lehrer.Click += new System.EventHandler(this.Browse_Lehrer_Click);
            // 
            // Browse_Schueler
            // 
            this.Browse_Schueler.BackgroundImage = global::Upload.Properties.Resources.Explorer;
            this.Browse_Schueler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Browse_Schueler.FlatAppearance.BorderSize = 0;
            this.Browse_Schueler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse_Schueler.Location = new System.Drawing.Point(298, 186);
            this.Browse_Schueler.Name = "Browse_Schueler";
            this.Browse_Schueler.Size = new System.Drawing.Size(35, 35);
            this.Browse_Schueler.TabIndex = 9;
            this.Browse_Schueler.UseVisualStyleBackColor = true;
            this.Browse_Schueler.Click += new System.EventHandler(this.Browse_Schueler_Click);
            // 
            // clear_schueler
            // 
            this.clear_schueler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.clear_schueler.BackgroundImage = global::Upload.Properties.Resources.Remove;
            this.clear_schueler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_schueler.FlatAppearance.BorderSize = 0;
            this.clear_schueler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_schueler.Location = new System.Drawing.Point(150, 257);
            this.clear_schueler.Name = "clear_schueler";
            this.clear_schueler.Size = new System.Drawing.Size(40, 40);
            this.clear_schueler.TabIndex = 4;
            this.clear_schueler.UseVisualStyleBackColor = false;
            this.clear_schueler.Click += new System.EventHandler(this.clear_schueler_Click);
            // 
            // clear_lehrer
            // 
            this.clear_lehrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.clear_lehrer.BackgroundImage = global::Upload.Properties.Resources.Remove;
            this.clear_lehrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_lehrer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.clear_lehrer.FlatAppearance.BorderSize = 0;
            this.clear_lehrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_lehrer.Location = new System.Drawing.Point(545, 257);
            this.clear_lehrer.Name = "clear_lehrer";
            this.clear_lehrer.Size = new System.Drawing.Size(40, 40);
            this.clear_lehrer.TabIndex = 3;
            this.clear_lehrer.UseVisualStyleBackColor = false;
            this.clear_lehrer.Click += new System.EventHandler(this.clear_lehrer_Click);
            // 
            // lehrer
            // 
            this.lehrer.AllowDrop = true;
            this.lehrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lehrer.BackgroundImage = global::Upload.Properties.Resources.Lehrer;
            this.lehrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lehrer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lehrer.Location = new System.Drawing.Point(450, 50);
            this.lehrer.Name = "lehrer";
            this.lehrer.Size = new System.Drawing.Size(240, 130);
            this.lehrer.TabIndex = 1;
            this.lehrer.DragDrop += new System.Windows.Forms.DragEventHandler(this.lehrer_DragDrop);
            this.lehrer.DragEnter += new System.Windows.Forms.DragEventHandler(this.lehrer_DragEnter);
            // 
            // schueler
            // 
            this.schueler.AllowDrop = true;
            this.schueler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.schueler.BackgroundImage = global::Upload.Properties.Resources.Schüler;
            this.schueler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.schueler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.schueler.Location = new System.Drawing.Point(50, 50);
            this.schueler.Name = "schueler";
            this.schueler.Size = new System.Drawing.Size(240, 130);
            this.schueler.TabIndex = 0;
            this.schueler.DragDrop += new System.Windows.Forms.DragEventHandler(this.schueler_DragDrop);
            this.schueler.DragEnter += new System.Windows.Forms.DragEventHandler(this.schueler_DragEnter);
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.Browse_Lehrer);
            this.Controls.Add(this.Browse_Schueler);
            this.Controls.Add(this.upload_lehrer_btn);
            this.Controls.Add(this.lehrer_file_txtbox);
            this.Controls.Add(this.schueler_file_txtbox);
            this.Controls.Add(this.upload_schueler_btn);
            this.Controls.Add(this.clear_schueler);
            this.Controls.Add(this.clear_lehrer);
            this.Controls.Add(this.lehrer);
            this.Controls.Add(this.schueler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UploadForm";
            this.Text = "Uploader";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel schueler;
		private System.Windows.Forms.Panel lehrer;
		private System.Windows.Forms.Button clear_lehrer;
		private System.Windows.Forms.Button clear_schueler;
		private System.Windows.Forms.Button upload_schueler_btn;
		private System.Windows.Forms.TextBox schueler_file_txtbox;
		private System.Windows.Forms.TextBox lehrer_file_txtbox;
		private System.Windows.Forms.Button upload_lehrer_btn;
		private System.Windows.Forms.Button Browse_Schueler;
		private System.Windows.Forms.Button Browse_Lehrer;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

