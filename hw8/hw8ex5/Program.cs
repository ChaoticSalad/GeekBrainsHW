using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//**Написать программу - преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
//    Черников Олег
namespace hw8ex5
{
    class Program
    {
        /// <summary>Magic code</summary>
        /// <param name="fileNameOpen">Csv file name</param>
        /// <param name="fileNameSave">Xml file name</param>
        static void Converter(string fileNameOpen, string fileNameSave)
        {
            string[] lines = File.ReadAllLines(fileNameOpen);
            string[] headers = { "Name", "Surname", "University", "Faculty", "Department", "Age", "Course", "Group", "City" };

            var xml = new XElement("Students",
               lines.Where((line, index) => index > 0).Select(line => new XElement("StudentIndo",
                  line.Split(';').Select((column, index) => new XElement(headers[index], column)))));

            xml.Save(fileNameSave);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("I'm gonna transform csv file to xml");

            Converter("students_6.csv", "students_8.xml");

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
