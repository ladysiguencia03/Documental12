using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Documental2
{
    public partial class FrmConfigColor : Form
    {
        public FrmConfigColor()
        {
            InitializeComponent();
        }
        //CAMBIAR EL COLOR DE LA LETRA
        private void btnLetra_Click(object sender, EventArgs e)
        {
            CldTema.ShowDialog();
            //txtLetra.Text = CldTema.Color.ToArgb().ToString();
            string _ColorName = GetColorName(CldTema.Color);
            FrmMenu.colorFont = CldTema.Color;
            
            Color myColor = ColorTranslator.FromHtml(_ColorName);
            txtLetra.Text = myColor.Name;
        }

        private string GetColorName(Color color)
        {
            var colorProperties = typeof(Color)
                .GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Where(p => p.PropertyType == typeof(Color));
            foreach (var colorProperty in colorProperties)
            {
                var colorPropertyValue = (Color)colorProperty.GetValue(null, null);
                if (colorPropertyValue.R == color.R
                       && colorPropertyValue.G == color.G
                       && colorPropertyValue.B == color.B)
                {
                    return colorPropertyValue.Name;
                }
            }

            //If unknown color, fallback to the hex value
            //(or you could return null, "Unkown" or whatever you want)
            return ColorTranslator.ToHtml(color);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        // CAMBIO DE FONDO
        private void btnFondo_Click(object sender, EventArgs e)
        {
            CldTema.ShowDialog();
            //txtLetra.Text = CldTema.Color.ToArgb().ToString();
            string _ColorName = GetColorName(CldTema.Color);
            FrmMenu.colorBack = CldTema.Color;
            Color myColor = ColorTranslator.FromHtml(_ColorName);
            txtFondo.Text = myColor.Name;  
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void FrmConfigColor_Load(object sender, EventArgs e)
        {
            Libreria.ResetAllControlsBackColor(this);
        }
    }
}
