using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentList
{
    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student ("Chris", "512-867-5309", "711 S Congress Ave.", -5000));
            students.Add(new Student("Kevin", "512-222-2222", "8009 S 1st Street", -2750));
            students.Add(new Student("Stacy", "512-999-9999", "8009 S 1st Street", 0));
            students.Add(new Student("Ashley", "512-888-8888", "8009 S 1st Street", -7000));

            IEnumerable<String> owedMoney = students
            .Where(s => s.Balance < 0)
            .Select(x => x.Name);

            foreach(string x in owedMoney){
                Console.WriteLine(x);
            }
        }
    }
    public class Student
    {
        public string Name;
        public string Phone;
        public string Address;
        public int Balance;

        public Student (string iName, string iPhone, string iAddress, int iBalance )
        {
            this.Name = iName;
            this.Phone = iPhone;
            this.Address = iAddress;
            this.Balance = iBalance;
        }
    }
}