using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.security;
using Org.BouncyCastle.X509;
using SysX509 = System.Security.Cryptography.X509Certificates;

namespace FirmarPDF
{

    public static class PDF
    {
        /// <summary>
        /// Firma un documento
        /// </summary>
        /// <param name="Source">Documento origen</param>
        /// <param name="Target">Documento destino</param>
        /// <param name="Certificate">Certificado a utilizar</param>
        /// <param name="Reason">Razón de la firma</param>
        /// <param name="Location">Ubicación</param>
        /// <param name="AddVisibleSign">Establece si hay que agregar la firma visible al documento</param>
        public static void SignHashed(string Source, string Target, SysX509.X509Certificate2 Certificate, string Reason, string Location, bool AddVisibleSign)
        {
            X509CertificateParser objCP = new X509CertificateParser();
            X509Certificate[] objChain = new X509Certificate[] { objCP.ReadCertificate(Certificate.RawData) };

            IList<ICrlClient> crlList = new List<ICrlClient>();
            crlList.Add(new CrlClientOnline(objChain));

            PdfReader objReader = new PdfReader(Source);
            PdfStamper objStamper = PdfStamper.CreateSignature(objReader, new FileStream(Target, FileMode.Create), '\0');
            // Creamos la apariencia
            PdfSignatureAppearance signatureAppearance = objStamper.SignatureAppearance;
            signatureAppearance.Reason = Reason;
            signatureAppearance.Location = Location;

            // Si está la firma visible:
            if (AddVisibleSign)
                signatureAppearance.SetVisibleSignature(new Rectangle(100, 100, 300, 200), 1, null); //signatureAppearance.SetVisibleSignature(new Rectangle(100, 100, 250, 150), objReader.NumberOfPages, "Signature");

            ITSAClient tsaClient = null;
            IOcspClient ocspClient = null;

            // Si se ha añadido el sello de tiempo


            // Creating the signature
            IExternalSignature externalSignature = new X509Certificate2Signature(Certificate, "SHA-1");
            MakeSignature.SignDetached(signatureAppearance, externalSignature, objChain, crlList, ocspClient, tsaClient, 0, CryptoStandard.CMS);

            if (objReader != null)
                objReader.Close();
            if (objStamper != null)
                objStamper.Close();
        }

        /// <summary>
        /// Crea la firma CMS/PKCS #7
        /// </summary>
        private static byte[] SignMsg(byte[] Message, SysX509.X509Certificate2 SignerCertificate, bool Detached)
        {
            //Creamos el contenedor
            ContentInfo contentInfo = new ContentInfo(Message);

            //Instanciamos el objeto SignedCms con el contenedor
            SignedCms objSignedCms = new SignedCms(contentInfo, Detached);

            //Creamos el "firmante"
            CmsSigner objCmsSigner = new CmsSigner(SignerCertificate);

            objCmsSigner.IncludeOption = SysX509.X509IncludeOption.EndCertOnly;

            objSignedCms.ComputeSignature(objCmsSigner, false);

            //Encodeamos el mensaje CMS/PKCS #7
            return objSignedCms.Encode();
        }
    }
}
