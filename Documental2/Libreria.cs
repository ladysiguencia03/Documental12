using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using Spire.Pdf;
using Spire.Pdf.Annotations;
using Spire.Pdf.Annotations.Appearance;
using Spire.Pdf.Graphics;
using PdfAppearance = Spire.Pdf.Annotations.Appearance.PdfAppearance;
using PdfImage = Spire.Pdf.Graphics.PdfImage;
using PdfTemplate = Spire.Pdf.Graphics.PdfTemplate;
using System.Drawing;
using System.IO;
using iTextSharp.text.pdf;
using System.Net.Mime;
using PdfFont = Spire.Pdf.Graphics.PdfFont;
using System.Windows.Forms;

namespace Documental2
{
    public static class Libreria
    { 
        //CONFIGURACION DE SLO LECTURA ARCHIVO 
        public static Spire.Pdf.PdfDocument putReadOnly(Spire.Pdf.PdfDocument pdfdocument)
        {
            for (int i = 0; i < pdfdocument.Pages.Count; i++)
            {
                System.Drawing.Image image = pdfdocument.SaveAsImage(i);
                image.Save(string.Format("ImagePage{0}.png", i), System.Drawing.Imaging.ImageFormat.Png);
            }

            Spire.Pdf.PdfDocument pdfDoc = new Spire.Pdf.PdfDocument();
            

            for (int i = 0; i < pdfdocument.Pages.Count; i++)
            {
                PdfMargins margin = new PdfMargins();
                margin.Top = 1;// unitCvtr.ConvertUnits(2.54f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
                margin.Bottom = 1;// margin.Top;
                margin.Left = 1;// unitCvtr.ConvertUnits(3.17f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
                margin.Right = 1;// margin.Left;
                System.Drawing.Image image = Image.FromFile(string.Format("ImagePage{0}.png", i));
                PdfImage pdfImg = PdfImage.FromImage(image);
                PdfPageBase page = pdfDoc.Pages.Add(PdfPageSize.A4, margin);

                float width = pdfImg.PhysicalDimension.Width; //pdfImg.Width * 0.3f;
                float height = pdfImg.PhysicalDimension.Height; //pdfImg.Height * 0.3f;
                PdfFont font = new PdfFont(PdfFontFamily.Helvetica, 8f);
                
                PdfSolidBrush brush1 = new PdfSolidBrush(Color.White);
        
                PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Center);
                page.Canvas.DrawString("Solo Lectura", font, brush1, 0, 0, format);

                page.Canvas.DrawImage(pdfImg, 200, 0, 0, width, height);
                image.Dispose();
            }
            for (int i = 0; i < pdfdocument.Pages.Count; i++)
            {

                File.Delete(string.Format("ImagePage{0}.png", i));

            }
            return pdfDoc;
        }
        //CONFIGURACION DE CORREO REMITENTE
        public static Boolean SendMail(string asunto, string cuerpo, string destinatario, string fileName)
        {
            try
            {
                var remitente = ConfigurationManager.AppSettings["remitente"];
                var clave = ConfigurationManager.AppSettings["clave"];
                var displayName = ConfigurationManager.AppSettings["nombreMostrar"];
                var cliente = ConfigurationManager.AppSettings["cliente"];
                var puerto = ConfigurationManager.AppSettings["puerto"];
                var piePagina = ConfigurationManager.AppSettings["piePagina"];
                var imagen = ConfigurationManager.AppSettings["imagen"];
                imagen = imagen == "" ? "logo.jpg": imagen;
                piePagina = piePagina.Replace("\r\n", "<br />").Replace("\n", "<br />").Replace("\r", "<br />");
                cuerpo = cuerpo.Replace("\r\n", "<br />").Replace("\n", "<br />").Replace("\r", "<br />");
                string htmlBody = string.Format("<html><body>{0}<br />{1}<br /> <img src=\"cid:Footer\" width=\"200\" height=\"300\" /></body></html>", cuerpo, piePagina);
                AlternateView avHtml = AlternateView.CreateAlternateViewFromString(htmlBody, Encoding.Default, MediaTypeNames.Text.Html);

                LinkedResource footer = new LinkedResource(imagen, MediaTypeNames.Image.Jpeg);
                footer.ContentId = "Footer";

                avHtml.LinkedResources.Add(footer);
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(cliente); //"smtp.gmail.com"
                mail.From = new MailAddress(remitente, displayName, Encoding.UTF8);
                mail.Subject = asunto; //"Prueba de Envío de Correo"
                mail.AlternateViews.Add(avHtml);
                mail.To.Add(destinatario);
                if (fileName != "")
                {
                    mail.Attachments.Add(new Attachment(fileName));
                }
                SmtpServer.Port = int.Parse(puerto); //Puerto que utiliza Gmail para sus servicios
                SmtpServer.EnableSsl = false;
                SmtpServer.UseDefaultCredentials = false;

                SmtpServer.Credentials = new System.Net.NetworkCredential(remitente, clave);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // CONFIGURACION DE GENERAR CLAVE AL ARCHIVO
        public static Boolean putClave(string fileName, string clave)
        {
            Spire.Pdf.PdfDocument pdfDoc = new Spire.Pdf.PdfDocument();
            using (var input = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var output = new FileStream(fileName.Replace(".pdf", "2.pdf"), FileMode.Create, FileAccess.Write, FileShare.None))
            {
                var reader = new PdfReader(input);
                PdfEncryptor.Encrypt(reader, output, true, clave, clave, PdfWriter.ALLOW_PRINTING);
            }
            pdfDoc.LoadFromFile(fileName.Replace(".pdf", "2.pdf"), clave);
            pdfDoc.SaveToFile(fileName);
            pdfDoc.Close();
            pdfDoc.Dispose();
            //File.Delete(fileName.Replace(".pdf", "2.pdf"));
            return true;
        }
        //CONFIGURACION DE AGREGAR QR AL ARCHIVO
        public static Spire.Pdf.PdfDocument putMarkWater(Spire.Pdf.PdfDocument pdfDoc, string fileImage)
        {
            for (int i = 0; i < pdfDoc.Pages.Count; i++)
            {
                PdfPageBase page = pdfDoc.Pages[i];
                PdfRubberStampAnnotation loStamp = new PdfRubberStampAnnotation(new RectangleF(new PointF(500, 690), new SizeF(50, 50)));
                PdfAppearance loApprearance = new PdfAppearance(loStamp);
                PdfImage image = PdfImage.FromFile(fileImage);
                PdfTemplate template = new PdfTemplate(190, 190);
                template.Graphics.DrawImage(image, 0, 0);
                //template.Graphics.SetTransparency(-0.3f);
                loApprearance.Normal = template;

                loStamp.Appearance = loApprearance;

                page.AnnotationsWidget.Add(loStamp);
            }
            return pdfDoc;

        }
        public static Spire.Pdf.PdfDocument putSign(Spire.Pdf.PdfDocument pdfDoc, string fileImage)
        {
            PdfPageBase page = pdfDoc.Pages[0];

            PdfRubberStampAnnotation loStamp = new PdfRubberStampAnnotation(new RectangleF(new PointF(-5, -5), new SizeF(60, 60)));
            PdfAppearance loApprearance = new PdfAppearance(loStamp);
            PdfImage image = PdfImage.FromFile(fileImage);


            PdfTemplate template = new PdfTemplate(160, 160);
            template.Graphics.DrawImage(image, 0, 0);
            loApprearance.Normal = template;

            loStamp.Appearance = loApprearance;

            page.AnnotationsWidget.Add(loStamp);

            return pdfDoc;


        }

       
        public static string GetIpAddress()

        {
            string ipLoc = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(ip => ip.AddressFamily.ToString().ToUpper().Equals("INTERNETWORK")).FirstOrDefault().ToString();

            return ipLoc;

        }

        public static void ResetAllControlsBackColor(Control control)
        {
            if (!(control is TextBox))
            {
                control.BackColor = FrmMenu.colorBack;
                control.ForeColor = FrmMenu.colorFont;
            }
            if (control.HasChildren)
            {
                // Recursively call this method for each child control.
                foreach (Control childControl in control.Controls)
                {
                    ResetAllControlsBackColor(childControl);
                }
            }
        }
    }


}
