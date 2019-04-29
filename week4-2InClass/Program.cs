using System;
using System.Collections.Generic;

namespace week4_2InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();

            for(int i = 0; i<3; i++){
            Person x = new Person();
            Console.WriteLine("Can I have your first name, please?");
            x.fName = Console.ReadLine();
            Console.WriteLine("Can I have your last name, please?");
            x.lName = Console.ReadLine();
            Console.WriteLine("What is your date of birth?");
            x.dob = Console.ReadLine();
            People.Add(x);

            }
            for( int i = 0; i<People.Count; i++){
            Person w = People[i];
            string fullName = w.nonStaticFullName();
            Console.WriteLine("Full Name: {0}", fullName);
            Console.WriteLine("DOB : {0}", w.dob);
        }
            

            Console.ReadLine();
        }

    }
    }

    class Family{
        public string mainAddress;
        public List<Person> adults = new List<Person>();
        public List<Person> children = new List<Person>();
        Person matriarch;
}
    
    class Person {
        public string fName;
        public string lName;
        public string dob;

        public static String FullName(string f, string l) {
        string full = f+ " " + l;
        return full;
    }
        public string nonStaticFullName(){
            return this.fName+" "+this.lName;
        }

}
