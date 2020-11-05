using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace XMLSerialization
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee Josh = new Employee();

            Josh.Name = "Conner Smith";
            Josh.Speed = 4;
            Josh.Design = 50;
            Josh.Research = 70;
            Josh.Software = 120;
            Josh.EntryDate = DateTime.Now;

            Console.WriteLine($"His name is {Josh.Name}, his speed is {Josh.Speed}. \nHis Disign, Research, and Software are {Josh.Design}, {Josh.Research}, {Josh.Software} is that order. \nHe joined on {Josh.EntryDate}");

            string FilePath = "C:/Users/Smith_Conner/Desktop/C#/Serialization/XMLSerialization/XMLSerialization/bin/Debug/";
            string FileName = "SerialNumberTwo.xml";
            XmlSerializer nuke = new XmlSerializer(typeof(Employee));
            using (TextWriter ser = new StreamWriter(FilePath + FileName, append: false))
            {
                nuke.Serialize(ser, Josh);
            }

            Console.WriteLine();

        }
    }
}
