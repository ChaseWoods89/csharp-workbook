using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> gradeBook = new Dictionary <string, string>();
            int i = 0;
            for( i = 0; i < 5; i++){
                Console.WriteLine("Give me the student's name.");
                string student = Console.ReadLine();
                Console.WriteLine("What kind of grades does student have? (please enter 4 grades 0-100)");
                gradeBook.Add(student,Console.ReadLine());
            }

            foreach(var student in gradeBook){
                Console.WriteLine(student);
            }




           Console.ReadLine();
        }
    }
}
