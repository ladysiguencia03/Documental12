namespace Documental2
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webEditor = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.colFiles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.pbrAvance = new System.Windows.Forms.ProgressBar();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.btnFirma = new System.Windows.Forms.Button();
            this.btnClave = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnLectura = new System.Windows.Forms.Button();
            this.btnArchivos = new System.Windows.Forms.Button();
            this.pctMinimice = new System.Windows.Forms.PictureBox();
            this.pctClose = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fbdDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdFiles = new System.Windows.Forms.OpenFileDialog();
            this.pnlBody.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.panel3);
            this.pnlBody.Controls.Add(this.panel2);
            this.pnlBody.Controls.Add(this.panel1);
            this.pnlBody.Controls.Add(this.pnlTitle);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1364, 399);
            this.pnlBody.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.webEditor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(205, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1159, 305);
            this.panel3.TabIndex = 5;
            // 
            // webEditor
            // 
            this.webEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webEditor.Location = new System.Drawing.Point(0, 0);
            this.webEditor.MinimumSize = new System.Drawing.Size(20, 20);
            this.webEditor.Name = "webEditor";
            this.webEditor.Size = new System.Drawing.Size(1159, 305);
            this.webEditor.TabIndex = 0;
            this.webEditor.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webEditor_DocumentCompleted);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstFiles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 305);
            this.panel2.TabIndex = 4;
            // 
            // lstFiles
            // 
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFiles});
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.HideSelection = false;
            this.lstFiles.Location = new System.Drawing.Point(0, 0);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(205, 305);
            this.lstFiles.TabIndex = 0;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged_1);
            // 
            // colFiles
            // 
            this.colFiles.Text = "Archivos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGrabar);
            this.panel1.Controls.Add(this.pbrAvance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 27);
            this.panel1.TabIndex = 3;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.Location = new System.Drawing.Point(1286, 3);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbrAvance
            // 
            this.pbrAvance.Location = new System.Drawing.Point(0, 4);
            this.pbrAvance.Name = "pbrAvance";
            this.pbrAvance.Size = new System.Drawing.Size(128, 23);
            this.pbrAvance.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbrAvance.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.panel4);
            this.pnlTitle.Controls.Add(this.pctMinimice);
            this.pnlTitle.Controls.Add(this.pctClose);
            this.pnlTitle.Controls.Add(this.LblTitulo);
            this.pnlTitle.Controls.Add(this.pnlLogo);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1364, 67);
            this.pnlTitle.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.btnConfig);
            this.panel4.Controls.Add(this.btnEnviarCorreo);
            this.panel4.Controls.Add(this.btnFirma);
            this.panel4.Controls.Add(this.btnClave);
            this.panel4.Controls.Add(this.btnMarca);
            this.panel4.Controls.Add(this.btnLectura);
            this.panel4.Controls.Add(this.btnArchivos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(69, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1295, 26);
            this.panel4.TabIndex = 7;
            // 
            // btnConfig
            // 
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.ImageIndex = 5;
            this.btnConfig.ImageList = this.imageList2;
            this.btnConfig.Location = new System.Drawing.Point(823, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(115, 26);
            this.btnConfig.TabIndex = 9;
            this.btnConfig.Text = "Configuracion";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "seleccionar_archivo.jpg");
            this.imageList2.Images.SetKeyName(1, "agregar_icono.png");
            this.imageList2.Images.SetKeyName(2, "solo_lectura.png");
            this.imageList2.Images.SetKeyName(3, "marca_agua.png");
            this.imageList2.Images.SetKeyName(4, "agregar_contrasena.png");
            this.imageList2.Images.SetKeyName(5, "ingreso_firma.jpg");
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarCorreo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEnviarCorreo.FlatAppearance.BorderSize = 0;
            this.btnEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCorreo.ForeColor = System.Drawing.Color.White;
            this.btnEnviarCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarCorreo.ImageIndex = 5;
            this.btnEnviarCorreo.ImageList = this.imageList2;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(687, 0);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(136, 26);
            this.btnEnviarCorreo.TabIndex = 7;
            this.btnEnviarCorreo.Text = "Enviar Correo";
            this.btnEnviarCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviarCorreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnviarCorreo.UseVisualStyleBackColor = true;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // btnFirma
            // 
            this.btnFirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirma.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFirma.FlatAppearance.BorderSize = 0;
            this.btnFirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirma.ForeColor = System.Drawing.Color.White;
            this.btnFirma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirma.ImageIndex = 5;
            this.btnFirma.ImageList = this.imageList2;
            this.btnFirma.Location = new System.Drawing.Point(551, 0);
            this.btnFirma.Name = "btnFirma";
            this.btnFirma.Size = new System.Drawing.Size(136, 26);
            this.btnFirma.TabIndex = 5;
            this.btnFirma.Text = "Ingreso de Firma";
            this.btnFirma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFirma.UseVisualStyleBackColor = true;
            this.btnFirma.Click += new System.EventHandler(this.btnFirma_Click);
            this.btnFirma.MouseLeave += new System.EventHandler(this.btnFirma_MouseLeave);
            this.btnFirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFirma_MouseMove);
            // 
            // btnClave
            // 
            this.btnClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClave.FlatAppearance.BorderSize = 0;
            this.btnClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClave.ForeColor = System.Drawing.Color.White;
            this.btnClave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClave.ImageIndex = 4;
            this.btnClave.ImageList = this.imageList2;
            this.btnClave.Location = new System.Drawing.Point(415, 0);
            this.btnClave.Name = "btnClave";
            this.btnClave.Size = new System.Drawing.Size(136, 26);
            this.btnClave.TabIndex = 4;
            this.btnClave.Text = "Agregar Contraseña";
            this.btnClave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClave.UseVisualStyleBackColor = true;
            this.btnClave.Click += new System.EventHandler(this.btnClave_Click);
            this.btnClave.MouseLeave += new System.EventHandler(this.btnClave_MouseLeave);
            this.btnClave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnClave_MouseMove);
            // 
            // btnMarca
            // 
            this.btnMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarca.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMarca.FlatAppearance.BorderSize = 0;
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.ForeColor = System.Drawing.Color.White;
            this.btnMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarca.ImageIndex = 3;
            this.btnMarca.ImageList = this.imageList2;
            this.btnMarca.Location = new System.Drawing.Point(300, 0);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(115, 26);
            this.btnMarca.TabIndex = 3;
            this.btnMarca.Text = "Generar QR";
            this.btnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            this.btnMarca.MouseLeave += new System.EventHandler(this.btnMarca_MouseLeave);
            this.btnMarca.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMarca_MouseMove);
            // 
            // btnLectura
            // 
            this.btnLectura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLectura.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLectura.FlatAppearance.BorderSize = 0;
            this.btnLectura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLectura.ForeColor = System.Drawing.Color.White;
            this.btnLectura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLectura.ImageIndex = 2;
            this.btnLectura.ImageList = this.imageList2;
            this.btnLectura.Location = new System.Drawing.Point(147, 0);
            this.btnLectura.Name = "btnLectura";
            this.btnLectura.Size = new System.Drawing.Size(153, 26);
            this.btnLectura.TabIndex = 2;
            this.btnLectura.Text = "Convertir Solo Lectura";
            this.btnLectura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLectura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLectura.UseVisualStyleBackColor = true;
            this.btnLectura.Click += new System.EventHandler(this.btnLectura_Click);
            this.btnLectura.MouseLeave += new System.EventHandler(this.btnLectura_MouseLeave);
            this.btnLectura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLectura_MouseMove);
            // 
            // btnArchivos
            // 
            this.btnArchivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchivos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnArchivos.FlatAppearance.BorderSize = 0;
            this.btnArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivos.ForeColor = System.Drawing.Color.White;
            this.btnArchivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchivos.ImageIndex = 0;
            this.btnArchivos.ImageList = this.imageList2;
            this.btnArchivos.Location = new System.Drawing.Point(0, 0);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Size = new System.Drawing.Size(147, 26);
            this.btnArchivos.TabIndex = 0;
            this.btnArchivos.Text = "Seleccionar Archivos";
            this.btnArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArchivos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnArchivos.UseVisualStyleBackColor = true;
            this.btnArchivos.Click += new System.EventHandler(this.btnArchivos_Click);
            this.btnArchivos.MouseLeave += new System.EventHandler(this.btnArchivos_MouseLeave);
            this.btnArchivos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // pctMinimice
            // 
            this.pctMinimice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMinimice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pctMinimice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMinimice.Image = global::Documental2.Properties.Resources.minimizar;
            this.pctMinimice.Location = new System.Drawing.Point(1298, 0);
            this.pctMinimice.Name = "pctMinimice";
            this.pctMinimice.Size = new System.Drawing.Size(32, 32);
            this.pctMinimice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMinimice.TabIndex = 5;
            this.pctMinimice.TabStop = false;
            this.pctMinimice.Click += new System.EventHandler(this.pctMinimice_Click);
            // 
            // pctClose
            // 
            this.pctClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pctClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctClose.Image = global::Documental2.Properties.Resources.close;
            this.pctClose.Location = new System.Drawing.Point(1332, 0);
            this.pctClose.Name = "pctClose";
            this.pctClose.Size = new System.Drawing.Size(32, 32);
            this.pctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctClose.TabIndex = 2;
            this.pctClose.TabStop = false;
            this.pctClose.Click += new System.EventHandler(this.pctClose_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitulo.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(69, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(1295, 41);
            this.LblTitulo.TabIndex = 6;
            this.LblTitulo.Text = "Generador de Archivos";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(69, 67);
            this.pnlLogo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Documental2.Properties.Resources.logo_copia;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ofdFiles
            // 
            this.ofdFiles.Multiselect = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1364, 399);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBody);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pnlBody.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctClose)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.FolderBrowserDialog fbdDirectory;
        private System.Windows.Forms.PictureBox pctClose;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pctMinimice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.ColumnHeader colFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pbrAvance;
        private System.Windows.Forms.OpenFileDialog ofdFiles;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnArchivos;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button btnLectura;
        private System.Windows.Forms.Button btnFirma;
        private System.Windows.Forms.Button btnClave;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.WebBrowser webEditor;
        private System.Windows.Forms.Button btnConfig;
    }
}