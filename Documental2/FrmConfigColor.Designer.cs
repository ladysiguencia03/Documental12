namespace Documental2
{
    partial class FrmConfigColor
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
            this.CldTema = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.txtFondo = new System.Windows.Forms.TextBox();
            this.btnLetra = new System.Windows.Forms.Button();
            this.btnFondo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color de Letra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color de Fondo:";
            // 
            // txtLetra
            // 
            this.txtLetra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLetra.Enabled = false;
            this.txtLetra.Location = new System.Drawing.Point(95, 13);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(119, 13);
            this.txtLetra.TabIndex = 2;
            // 
            // txtFondo
            // 
            this.txtFondo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFondo.Enabled = false;
            this.txtFondo.Location = new System.Drawing.Point(95, 41);
            this.txtFondo.Name = "txtFondo";
            this.txtFondo.Size = new System.Drawing.Size(119, 13);
            this.txtFondo.TabIndex = 3;
            // 
            // btnLetra
            // 
            this.btnLetra.FlatAppearance.BorderSize = 0;
            this.btnLetra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetra.ForeColor = System.Drawing.Color.White;
            this.btnLetra.Location = new System.Drawing.Point(220, 8);
            this.btnLetra.Name = "btnLetra";
            this.btnLetra.Size = new System.Drawing.Size(33, 23);
            this.btnLetra.TabIndex = 24;
            this.btnLetra.Text = "...";
            this.btnLetra.UseVisualStyleBackColor = true;
            this.btnLetra.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // btnFondo
            // 
            this.btnFondo.FlatAppearance.BorderSize = 0;
            this.btnFondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFondo.ForeColor = System.Drawing.Color.White;
            this.btnFondo.Location = new System.Drawing.Point(220, 36);
            this.btnFondo.Name = "btnFondo";
            this.btnFondo.Size = new System.Drawing.Size(33, 23);
            this.btnFondo.TabIndex = 25;
            this.btnFondo.Text = "...";
            this.btnFondo.UseVisualStyleBackColor = true;
            this.btnFondo.Click += new System.EventHandler(this.btnFondo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(150, 77);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(54, 77);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 26;
            this.btnGenerar.Text = "Aceptar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // FrmConfigColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(268, 121);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnFondo);
            this.Controls.Add(this.btnLetra);
            this.Controls.Add(this.txtFondo);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfigColor";
            this.Text = "FrmConfigColor";
            this.Load += new System.EventHandler(this.FrmConfigColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog CldTema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.TextBox txtFondo;
        private System.Windows.Forms.Button btnLetra;
        private System.Windows.Forms.Button btnFondo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
    }
}