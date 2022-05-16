using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Documental2
{
    public partial class FrmConfiguracion : Form
    {
        string Smtp;
        Configuration config;
        public FrmConfiguracion()
        {
            InitializeComponent();
        }
        //BOTON SALIR
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //CONFIGURACION PAGINA PRINCIPAL
        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            Libreria.ResetAllControlsBackColor(this);
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            txtRemitente.Text = ConfigurationManager.AppSettings["remitente"];
            txtClave.Text = ConfigurationManager.AppSettings["clave"];
            txtNombre.Text = ConfigurationManager.AppSettings["nombreMostrar"];
            Smtp = ConfigurationManager.AppSettings["cliente"];
            cmbSmtp.SelectedItem = "Hotmail";
            if (Smtp.Equals("smtp.gmail.com"))
            {
                cmbSmtp.SelectedItem = "Gmail";
            }
            
            txtPuerto.Value = int.Parse(ConfigurationManager.AppSettings["puerto"]);
            txtPiePagina.Text = ConfigurationManager.AppSettings["piePagina"];
        }
        // BOTON DE GRABAR EL REMITENTE
        private void button2_Click(object sender, EventArgs e)
        {
            
            config.AppSettings.Settings["remitente"].Value = txtRemitente.Text;
            config.AppSettings.Settings["clave"].Value = txtClave.Text;
            config.AppSettings.Settings["nombreMostrar"].Value = txtNombre.Text;
            config.AppSettings.Settings["puerto"].Value = txtPuerto.Value.ToString();
            config.AppSettings.Settings["piePagina"].Value = txtPiePagina.Text;
            config.AppSettings.Settings["cliente"].Value = Smtp;
            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("Configuraciones guardadas con exito!");
            DialogResult = DialogResult.OK;
            this.Close();
        }
        //CONFIGURACION DE PUERTOS
        private void cmbSmtp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            Smtp = config.AppSettings.Settings["clienteHotmail"].Value;
            txtPuerto.Value = int.Parse(config.AppSettings.Settings["puertoHotmail"].Value);
            if (c.GetItemText(c.SelectedItem).ToLower().Equals("gmail"))
            {
                Smtp = config.AppSettings.Settings["clienteGmail"].Value;
                txtPuerto.Value = int.Parse(config.AppSettings.Settings["puertoGmail"].Value);
            }
            MessageBox.Show(c.GetItemText(c.SelectedItem));
        }
        //CHECK DE LOS PUERTOS
        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            txtPuerto.Enabled = ((CheckBox)(sender)).Checked;
        }
    }
}
