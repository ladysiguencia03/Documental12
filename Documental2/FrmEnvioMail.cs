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
    public partial class FrmEnvioMail : Form
    {
        public string fileName;
        public FrmEnvioMail()
        {
            InitializeComponent();
        }
        public FrmEnvioMail(string nombre)
        {
            InitializeComponent();
            fileName = nombre;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //BOTON DE ENVIAR EMAIL
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Libreria.SendMail(txtAsunto.Text, txtCuerpo.Text, txtPara.Text, fileName);
            DialogResult = DialogResult.OK;
            this.Close();
        }
        //INSTANCIAR DE LA LIBRERIA
        private void FrmEnvioMail_Load(object sender, EventArgs e)
        {
            Libreria.ResetAllControlsBackColor(this);
            lblAdjunto.Text = fileName;

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        //BOTON SALIR
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
