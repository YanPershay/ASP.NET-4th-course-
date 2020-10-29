using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Asmx
{
    public partial class Form1 : Form
    {
        Asmx.Simplex.Simplex simplex;
        
        public Form1()
        {
            simplex = new Simplex.Simplex();
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int x, y;
            if(int.TryParse(textX.Text, out x) && int.TryParse(textY.Text, out y))
            {
                textAddResponse.Text = simplex.Add(x, y).ToString();
            }
            else
            {
                MessageBox.Show("Please, enter Int values.");
            }
        }

        private void Concat_Click(object sender, EventArgs e)
        {
            double d;
            if(double.TryParse(textD.Text, out d))
            {
                textConcatResponse.Text = simplex.Concat(textS.Text, d);
            }
            else
            {
                MessageBox.Show("Please, enter Double value to D.");
            }
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            int k1, k2;
            float f1, f2;
            var a1 = new Simplex.A();
            var a2 = new Simplex.A();

            if (int.TryParse(textA1K.Text, out k1) && float.TryParse(textA1F.Text, out f1)
            && int.TryParse(textA2K.Text, out k2) && float.TryParse(textA2F.Text, out f2))
            {
                a1.s = textA1S.Text;
                a1.k = k1;
                a1.f = f1;

                a2.s = textA2S.Text;
                a2.k = k2;
                a2.f = f2;

                var result = simplex.Sum(a1, a2);
                textSumResponse.Text = result.s + " " + result.k + " " + result.f;
            }
            else
            {
                MessageBox.Show("Please, enter correct values.");
            }
        }

        private void SumAsmx_Click(object sender, EventArgs e)
        {
            var _url = "https://localhost:44343/Simplex.asmx";
           // var _action = "https://localhost:44343/Simplex.asmx?op=Sum";

            XmlDocument soapEnvelopeXml = CreateSoapEnvelope();
            HttpWebRequest webRequest = CreateWebRequest(_url);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // begin async call to web request.
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // suspend this thread until call is complete. You might want to
            // do something usefull here like update your UI.
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
            string soapResult;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
                Console.Write(soapResult);
            }
        }

        private static HttpWebRequest CreateWebRequest(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
           // webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "application/soap+xml;charset=\"utf-8\"";
            //webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope()
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>
            <soap12:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap12=""http://www.w3.org/2003/05/soap-envelope"">
              <soap12:Body>
                <Sum xmlns=""http://pyb/"">
                  <a1>
                    <s>string</s>
                    <k>9</k>
                    <f>11</f>
                  </a1>
                  <a2>
                    <s>hello</s>
                    <k>34</k>
                    <f>76</f>
                  </a2>
                </Sum>
              </soap12:Body>
            </soap12:Envelope>");
            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
    }
}
