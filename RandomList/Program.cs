using System;
using System.Collections.Generic;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<string> students = new List<string>{};
            students.Add("Hank");
            students.Add("Peggy");
            students.Add("Bobby");
            students.Add("LadyBird");
            students.Add("Dale");
            students.Add("Khan");
            students.Add("Bill");

            Random randomName = new Random();
            

            foreach(string person in students){
                Console.WriteLine(randomName.Next(0,6));
            }

            
            
        }
    }
}
