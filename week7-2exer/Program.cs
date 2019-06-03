using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace week7_2exer
{

    class Student
    {
        public string name;
        public int age;
        public Student(string iName, int iAge)
        {
            this.name = iName;
            this.age = iAge;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Mark", 4));
            students.Add(new Student("Mary", 5));
            students.Add(new Student("Bob", 4));
            students.Add(new Student("Matt", 3));

            IEnumerable<Student> lessThanSix = students.
                    Where(s => s.age < 6).
                    Where(x => x.name.StartsWith("M"));

            foreach(Student s in lessThanSix)
            {
                Console.WriteLine(s.name);
            }
        }

    }


}
