using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Переделать программу Пример использования коллекций для решения следующих задач:
//а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
//в) отсортировать список по возрасту студента;
//г) * отсортировать список по курсу и возрасту студента;
//      Черников Олег
namespace hw6ex3
{
    class Student
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
    }
    class Program
    {

        static void CompareAgeAndCourse(ref List<Student> list)
        {
            list.Sort(delegate (Student st1, Student st2) { return String.Compare(st1.age.ToString(), st2.age.ToString()); });
            list.Sort(delegate (Student st1, Student st2) { return String.Compare(st1.course.ToString(), st2.course.ToString()); });
        }

        static void Main(string[] args)
        {
            int bakalavr = 0;
            int magistr = 0;
            int fifthCourse = 0;
            int sixthCourse = 0;
            string courseFreq = String.Empty;
            Dictionary<int, int> course = new Dictionary<int, int>();
            List<Student> students = new List<Student>();
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_6.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(',');
                    students.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                    if (int.Parse(s[6]) == 5) fifthCourse++;
                    if (int.Parse(s[6]) == 6) sixthCourse++;
                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20)
                    {
                        if (course.ContainsKey(int.Parse(s[6])))
                            course[int.Parse(s[6])]++;
                        else
                            course[int.Parse(s[6])] = 1;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Error! ESC - to stop");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            students.Sort(delegate (Student st1, Student st2) { return String.Compare(st1.firstName, st2.firstName);  });
            foreach (var v in students)
                Console.WriteLine(v.firstName);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Sort by age: ");
            students.Sort(delegate (Student st1, Student st2) { return String.Compare(st1.age.ToString(), st2.age.ToString()); });
            foreach (var v in students)
                Console.WriteLine(v.firstName);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Sort by course and age: ");
            CompareAgeAndCourse(ref students);
            foreach (var v in students)
                Console.WriteLine(v.firstName);

            Console.WriteLine(new string('-', 30));

            Console.WriteLine($"Number of students: {students.Count}");
            Console.WriteLine($"Masters: {magistr}");
            Console.WriteLine($"Bachelors: {bakalavr}");
            Console.WriteLine($"Students on fifth course: {fifthCourse}");
            Console.WriteLine($"Students on sixth course: {sixthCourse}");
            foreach (var pair in course)
                courseFreq += $"On {pair.Key} course {pair.Value} students\n";
            Console.WriteLine(courseFreq);
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();

        }
    }

}
