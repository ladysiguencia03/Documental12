using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Documental2
{
    public partial class FrmConfig : Form
    {
        static string dirPruebas = @"c:\";
        string ficPruebas = Path.Combine(dirPruebas, "MisClaves_CS.xml");
        public FrmConfig()
        {
            InitializeComponent();
        }
        
        private void FrmConfig_Load(object sender, EventArgs e)
        {
            Libreria.ResetAllControlsBackColor(this);
        }
        //BOTON DE GENRAR CONTRASEÑA CLAVE
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.AppSettings.Settings["claveSistema"].Value = txtClave.Text;
            config.AppSettings.Settings["claveAdministrador"].Value = txtClave.Text;

            sfdCifrado.ShowDialog();
            ficPruebas = sfdCifrado.FileName;
            if (File.Exists(ficPruebas) == false)
            {
                Cifrado.crearXMLclaves(ficPruebas);
            }

            string xmlKeys = Cifrado.clavesXML(ficPruebas);

            byte[] datos = Cifrado.cifrar(txtClave.Text, xmlKeys);
            //File.WriteAllBytes("KeyPrivate", datos);
            File.WriteAllBytes("KeyPrivateAdmin", datos);
            //string res = Encoding.Default.GetString(datos);

            string[] lines = File.ReadAllLines(ficPruebas);
            string res = String.Join(Environment.NewLine, lines);

            txtLlave.Text = res;
            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");

        }
        //BOTON SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
