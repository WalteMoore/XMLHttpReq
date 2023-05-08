using System;
using System.Net;
using System.Xml;

namespace xmlReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(xmlreader());
            Console.ReadKey();
        }

        private static string xmlreader()
        {
            try
            {
                string url = @"https://raw.githubusercontent.com/WalteMoore/XMLHttpReq/main/xmlhttp.xml";
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                XmlTextReader reader = new XmlTextReader(url);
                while (reader.Read())
                    if (reader.Name.Contains("author"))
                        return reader.ReadString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return string.Empty;
        }
    }
}