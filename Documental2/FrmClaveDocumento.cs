using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Documental2
{
    public partial class FrmClaveDocumento : Form
    {
        public string Clave { get; set; }

        public FrmClaveDocumento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //BOTON DE ACEPTAR CAMBIO DE CLAVE
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string cadena = "abcdefghijklmnopqrstuvwxyz";
            cadena += cadena.ToUpper();
            string numero = "0123456789";
            int minimo = 8;
            bool tieneNumero = false;
            bool tieneLetra = false;
            //string caracter = "!$%&/()=?¡@:;.,<>-_";
            if (txtClave.TextLength < minimo)
            {
                MessageBox.Show("Debe contener minimo " + minimo.ToString() + " caracteres");
                return;
            }
            for (int i = 0; i < txtClave.TextLength; i++)
            {
                if (cadena.Contains(txtClave.Text[i].ToString()))
                {
                    tieneLetra = true;
                }
                if (numero.Contains(txtClave.Text[i].ToString()))
                {
                    tieneNumero = true;
                }

            }
            if (!(tieneNumero && tieneLetra))
            {
                MessageBox.Show("Debe contener al menos un numero y una letra");
                return;
            }
            
            if (txtClave.Text.Equals(txtRepetir.Text))
            {
                Clave = txtClave.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No coinciden las claves");
            }
        }
        //INSTANCIAR DE LIBRERIA
        private void FrmClaveDocumento_Load(object sender, EventArgs e)
        {
            Libreria.ResetAllControlsBackColor(this);
        }
        //BOTON DE SALIR DE CAMBIO DE CLAVE
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Clave = "";
            this.Close();
        }

        private void txtClave_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
