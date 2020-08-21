using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
//**Написать программу - преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
//    Черников Олег
namespace hw8ex5
{
    public class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }
        
        public Student()
        {

        }
    }

    class Program
    {
        /// <summary>Magic code</summary>
        /// <param name="fileNameOpen">Csv file name</param>
        /// <param name="fileNameSave">Xml file name</param>
        static void Converter(string fileNameOpen, string fileNameSave)
        {
            List<Student> students = new List<Student>();
            StreamReader sr = new StreamReader(fileNameOpen); 
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(',');
                    students.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Error! ESC - to stop");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) 
                        return;
                }
            }
            sr.Close();

            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>)); 
            Stream fStream = new FileStream(fileNameSave, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, students);
            fStream.Close();
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
