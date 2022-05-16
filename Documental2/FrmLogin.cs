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
    public partial class FrmLogin : Form
    {
        string clave;
        string opcion;
        string nivel;
        public FrmLogin(string op)
        {
            opcion = op;
            InitializeComponent();
        }
        //BOTON DE SELECCION LA CLAVE EN EL DIRECTORIO
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ofdLlave.InitialDirectory = "C:\\";
            // filtro de archivos.

            ofdLlave.Multiselect = false;
            // codigo para abrir el cuadro de dialogo
            if (ofdLlave.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofdLlave.FileName;
                txtFile.Text = fileName;
                byte[] datos;
                if (opcion.ToLower().Equals("principal"))
                {
                    datos = System.IO.File.ReadAllBytes("KeyPrivate");
                    nivel = "claveSistema";
                }
                else
                {
                    datos = System.IO.File.ReadAllBytes("KeyPrivateAdmin");
                    nivel = "claveAdministrador";
                }
                    
                string xmlKeys = Cifrado.clavesXML(fileName);
                clave = Cifrado.descifrar(datos, xmlKeys);
                
            }
        }
        //BOTON SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (opcion.ToLower().Equals("principal"))
            {
                Application.Exit();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
            
        }
        //BOTON DE VERIFICACION DE CLAVE
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (clave.Equals(config.AppSettings.Settings[nivel].Value))
            {
                this.Hide();
                if (opcion.ToLower().Equals("principal"))
                {
                    FrmMenu frmMenu = new FrmMenu();
                    frmMenu.Show();
                }
                else
                {
                    config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    string para = ConfigurationManager.AppSettings["remitente"];
                    Libreria.SendMail("Acceso a Administrador", string.Format("Se esta queriendo cambiar la clave ip {0}", Libreria.GetIpAddress()), para, "");
                    FrmConfig frm = new FrmConfig();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Archivo de Llave incorrecto");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}