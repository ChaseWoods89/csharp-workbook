using System;
using System.Collections.Generic;
using System.Linq;

namespace week7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Mark", 4));
            students.Add(new Student("Mary", 5));
            students.Add(new Student("Bob", 4));
            students.Add(new Student("Matt", 3));

            IEnumerable<String> lessThanSix = students
            .Where(s => s.age < 6)
            .Where(x => x.name.StartsWith("M"))
            .Select(s => s.name);

            foreach(string s in lessThanSix){
                Console.WriteLine(s);
            }
            }
        }
    class Student
    {
        public String name;
        public int age;
        public Student(string iName, int iAge){
            this.name = iName;
            this.age = iAge;
        }
    }
    }

