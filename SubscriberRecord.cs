using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlDemoProject
{
    public class SubscriberRecord
    {
        [XmlElement("FirstName")]
        public String FirstName { get; set; }
        [XmlElement("LastName")]
        public String LastName { get; set; }
        [XmlElement("DOB")]
        public String DOB { get; set; }
    }
}