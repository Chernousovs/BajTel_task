using System;
using System.IO;
using System.Text.Json;

namespace BaiTELtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = "../../A_JSON_dati.json";
            string xmlFilePath = "../../B_XML_dati.xml";

            string text = File.ReadAllText(jsonFilePath);
            var salesOrder = JsonSerializer.Deserialize<SalesOrder>(text);

            StreamWriter writer = new StreamWriter(xmlFilePath);
            salesOrder.ToXmlFile(writer);

            Console.WriteLine("Check results in {0}", Path.GetFullPath(xmlFilePath));
            Console.ReadLine();
        }
    }
}
