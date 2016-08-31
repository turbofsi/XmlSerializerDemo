using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "C:\\Logs\\sampleReport.xml";

            Response res = null;

            XmlSerializer xser = new XmlSerializer(typeof(Response));

            StreamReader reader = new StreamReader(filePath);

            res = (Response)xser.Deserialize(reader);
            reader.Close();
            Console.ReadKey(); 
        }
    }
}
