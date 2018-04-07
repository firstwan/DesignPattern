using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    public class FunctionTestingClass
    {
        static void Main()
        {
            Dictionary<string, string> param = new Dictionary<string, string>();
            string xmlstring = "<?xml version=\"1.0\" encoding=\"utf-8\"?><string xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:nil=\"true\" xmlns=\"http://payout.sdapay.net/\"/>";

            XmlDocument xm = new XmlDocument();
            xm.LoadXml(xmlstring);

            var XmlNS = new XmlNamespaceManager(xm.NameTable);
            XmlNS.AddNamespace("ns", "http://payout.sdapay.net/");
            //XmlNS.AddNamespace("xsd", "http://www.w3.org/2001/XMLSchema");
            //XmlNS.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            //XmlNS.AddNamespace("nil", "true");

            string test = xm.SelectSingleNode("ns:string", XmlNS).InnerText;


            var decryp = "<TransferInformation><Id>12345</Id><IntoAccount>1243523458234</IntoAccount><RecordsState>2</RecordsState><Tip>Testing</Tip><ProcessingTime>2011/10/18 21:57:55</ProcessingTime></TransferInformation>";

            RequeryModel result = new RequeryModel();
            XmlSerializer serializer = new XmlSerializer(typeof(RequeryModel));
            var reader = new XmlTextReader(new MemoryStream(Encoding.UTF8.GetBytes(decryp)));
            var gotest = (RequeryModel)serializer.Deserialize(reader);
        }

        [Serializable]
        [XmlRoot(ElementName = "TransferInformation")]
        public class RequeryModel
        {
            [XmlElement("Id")]
            public string Id { set; get; }

            [XmlElement("IntoAccount")]
            public string IntoAccount { set; get; }

            [XmlElement("IntoName")]
            public string IntoName { set; get; }

            [XmlElement("IntoBank1")]
            public string IntoBank1 { set; get; }

            [XmlElement("IntoAmount")]
            public decimal IntoAmount { set; get; }

            [XmlElement("RecordsState")]
            public int RecordsState { set; get; }

            [XmlElement("Tip")]
            public string Tip { set; get; }

            [XmlElement("ProcessingTime")]
            public string ProcessingTime { set; get; }

            [XmlElement("SerialNumber")]
            public string SerialNumber { set; get; }
        }
    }
}
