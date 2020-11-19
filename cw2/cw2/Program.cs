using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dane, wynik, typ;
            List<Student> studentData = new List<Student>();

            
            
            using (var stream = new StreamReader(File.OpenRead("dane.csv"))) {
                string line = null;
                while ((line = stream.ReadLine()) != null) {

                    string[] student = line.Split(',');
                    
                    var st = new Student
                    {
                        Imie = student[0],
                        Nazwisko = student[1],
                        Kierunek = student[2],
                        Mode = student[3],
                        numerIndeksu = student[4],
                        dataUrodzenia = student[5],
                        email = student[6],
                        imieMatki = student[7],
                        imieOjca = student[8]

                    };
                    studentData.Add(st);
                }
            }
          

                FileStream writer = new FileStream(@"żesult.xml", FileMode.Create);
                    
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                serializer.Serialize(writer, studentData);
         


            
            

        }

 
        
        
//methods---------------------------------

              
    }
}
//---------weryfikacja parametrów
/*if (args == null || args.Length < 3)
{
    dane = "dane.csv";
    wynik = "żesult.xml";
    typ = "xml";
}
else
{
    dane = args[0];
    wynik = args[1];
    typ = args[2];
    if (typ != "xml")
    {
        typ = "xml"; //weryfikacja warunku - na razie tylko xml
        Console.Write("\npoprawiono trzeci parametr (typ danych) na xml");
    }
}*/
//-----------------------------