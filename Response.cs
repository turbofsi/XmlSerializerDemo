using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlDemoProject
{
    [Serializable]
    [XmlRoot("Report")]
    public class Response
    {
        [XmlElement("ReportName")] 
        public String ReportName { get; set; }
        [XmlElement("Status")] 
        public String Status { get; set; }
        [XmlElement("Record")] 
        public List<SubscriberRecord> Record { get; set; }

    }
}
