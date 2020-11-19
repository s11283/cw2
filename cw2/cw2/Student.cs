using System;
using System.Xml.Serialization;

namespace cw2
{
    [Serializable]
    public class Student
    {

        [XmlElement(ElementName = "Imie")]
        public string Imie { get; set; }
        [XmlElement(ElementName = "Nazwisko")]
        public string Nazwisko { get; set; }
        [XmlElement(ElementName = "Studia")]
        public string Kierunek { get; set; }
        [XmlElement(ElementName = "Mode")]
        public string Mode { get; set; }
        [XmlElement(ElementName = "Indeks")]
        public string numerIndeksu { get; set; }
        [XmlElement(ElementName = "dataUrodzenia")]
        public string dataUrodzenia { get; set; }
        [XmlElement(ElementName = "email")]
        public string email { get; set; }
        [XmlElement(ElementName = "Imie matki")]
        public string imieMatki { get; set; }
        [XmlElement(ElementName = "Imie ojca")]
        public string imieOjca { get; set; }



    }
}