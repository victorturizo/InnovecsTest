using System.Xml.Serialization;

namespace InnovecsTest.Core.Models
{
    [XmlRoot(ElementName = "InputAPI3")]
    public class InputAPI3
    {
        [XmlElement]
        public string? Source { get; set; }


        [XmlElement]
        public string? Destination { get; set; }


        [XmlElement]
        public Packages? Packages { get; set; }
    }


    [XmlRoot(ElementName = "Packages")]
    public class Packages
    {
        [XmlElement]
        public string Package { get; set; }
    }
}
