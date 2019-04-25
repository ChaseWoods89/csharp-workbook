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
                string grades = Console.ReadLine();
                gradeBook.Add(student,grades);
            }

            foreach(var student in gradeBook.Keys){

                string grades = gradeBook[student];
                List<int> gradesNumbers = new List<int>(Array.ConvertAll(grades.Split(','), int.Parse));
                Console.WriteLine(Math.Max(gradesNumbers[0],gradesNumbers[3]));
                Console.WriteLine(Math.Min(gradesNumbers[0],gradesNumbers[3]));

                foreach(var person in gradeBook){
                    
                    Console.WriteLine(gradeBook);
                }                 
                
            }




           Console.ReadLine();
        }
    }
}
