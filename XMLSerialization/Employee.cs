using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace XMLSerialization
{
    //[Serializable]
    [XmlRoot("New Employees", Namespace = "www.nerdinc.ninja")]
    public class Employee
    {
        [XmlAttribute("Employee Name")]
        public string Name { get; set; }
        [XmlElement("Employee Speed")]
        public int Speed { get; set; }
        [XmlElement("Employee Design")]
        public int Design { get; set; }
        [XmlElement("Employee Research")]
        public int Research { get; set; }
        [XmlElement("Employee Software")]
        public int Software { get; set; }

        public DateTime EntryDate {get; set;}
    }
}
