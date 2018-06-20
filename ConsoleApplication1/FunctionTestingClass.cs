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
        static void Main1()
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                string xmlstring = "<?xml version=\"1.0\" encoding=\"utf-8\"?><xml><amount>39000000000</amount></xml>";

                XmlDocument xm = new XmlDocument();
                xm.LoadXml(xmlstring);


                RequeryModel result = new RequeryModel();
                XmlSerializer serializer = new XmlSerializer(typeof(RequeryModel));
                using (TextReader reader = new StringReader(xmlstring))
                {
                    var _eeziePayResponseModel = (RequeryModel)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {

            }
        }

        [XmlRoot(ElementName = "xml")]
        public class RequeryModel
        {
            [XmlElement(ElementName = "amount")]
            public decimal FundoutAmt { get; set; }
        }
    }
}
