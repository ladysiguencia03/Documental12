using System;
using Gma.QrCodeNet.Encoding;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using System.Drawing.Imaging;

namespace Documental2
{
    public partial class MarcaQR : Form
    {
        public string Texto = "";
        private bool esMarcaAgua = false;
        public MarcaQR()
        {
            InitializeComponent();
        }
        //BOTON DE GENERAR QR
        private void button1_Click(object sender, EventArgs e)
        {
            QrEncoder qrEnconder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEnconder.TryEncode(richTextBox1.Text, out qrCode);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero),Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));
            panel1.BackgroundImage = imagen;

            // Guardad en el disco duro la imagen (carpeta del proyecto)
            imagen.Save("ImagenQr.png", ImageFormat.Png);
            button2.Enabled = true;
            //@"C:\Users\BRYAN\Desktop\" +


        }
        //BOTON DE GUARDAR QR
        private void button2_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)panel1.BackgroundImage.Clone();
            SaveFileDialog CajaDialogoGuardar = new SaveFileDialog();
            CajaDialogoGuardar.AddExtension = true;
            CajaDialogoGuardar.InitialDirectory = "C:\\";
            CajaDialogoGuardar.Filter = "Image PNG (*.png)|*.png";
            CajaDialogoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(CajaDialogoGuardar.FileName))
            {
                imgFinal.Save(CajaDialogoGuardar.FileName, ImageFormat.Png);
                MessageBox.Show("Se guardo QR exitosamente");
            }
            imgFinal.Dispose();
            button3.Enabled = true;
        }
        //BOTON DE AGREGAR AL ARCHIVO EL QR
        private void button3_Click(object sender, EventArgs e)
        {
            ofdFiles.InitialDirectory = "C:\\";
            // filtro de archivos.
            ofdFiles.Filter = "Documentos (*.jpg; *.png)|*.jpg; *.png";
            ofdFiles.Multiselect = true;


            // codigo para abrir el cuadro de dialogo
            if (ofdFiles.ShowDialog() == DialogResult.OK)
            {

                Texto = ofdFiles.FileName;
                esMarcaAgua = true;

                DialogResult = DialogResult.OK;
                this.Close();

                MessageBox.Show("marca agregada de forma correcta");

            }
            else
            {
                MessageBox.Show("Debe seleccionar una imagen ");
            }
        }
    }
}
