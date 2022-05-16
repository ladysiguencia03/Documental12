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
    public partial class FrmMenuConfig : Form
    {
        public FrmMenuConfig()
        {
            InitializeComponent();
        }
        //BOTON DE INSTANCIAR CONFIGURACION DE CORREO REMITENTE
        private void btnCorreo_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frm = new FrmConfiguracion();  
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }

        }
        //BOTON DE INSTANCIAR DE ADMINISTRACION
        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin("secundario");
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }
        //BOTON SALIR
        private void bntSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        //BOTON DE IINSTANCIAR TEMAS
        private void btnTema_Click(object sender, EventArgs e)
        {
            FrmConfigColor frm = new FrmConfigColor();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Libreria.ResetAllControlsBackColor(this);
            }
        }
        //INSTANCIAR DE LIBRERIAS
        private void FrmMenuConfig_Load(object sender, EventArgs e)
        {
            Libreria.ResetAllControlsBackColor(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
