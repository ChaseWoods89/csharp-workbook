using System;
using System.Collections.Generic;

namespace ScopesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List<string> Students = new List<string>();
            Students.Add("Ross");
            Students.Add("Rachel");
            Students.Add("Joey");
            Students.Add("Chandler");
            Students.Add("Monica");
            Students.Add("Phoebe");

            foreach(string student in Students)
                {
                    int size = student.Length;
                    Console.WriteLine(student+ " has " +size + " letters in their name");
                    
                }*/
                String [] students = new String[]{"Jane", "John", "Malcolm"};
               // for( int i = 0; i < students.Length; i++){
                 //   Console.WriteLine(i +" => " + students[i]);
                    
        //}
                foreach(String student in students){
                    Console.WriteLine(student);
                }
                
            

        }
    }
}
