using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp
{
    public class Utils
    {
         
        public void printMenu() {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Task as Done");
            Console.WriteLine("3. List Pending Tasks");
            Console.WriteLine("4. List Done Tasks");
            Console.WriteLine("5. List All Tasks");
            Console.WriteLine("6. Delete Item");
            Console.WriteLine("7. Close Program");
            Console.WriteLine("");
            Console.WriteLine("Please select the number you want.");           
        }

        public string getInput(){
            string userInput = Console.ReadLine();

            return userInput;
        }

        public void printError(string errormessage){
            Console.WriteLine(errormessage);
        }

        public void printMsg(string message){
            Console.WriteLine(message);
        }
        public void clear(){
            Console.Clear();
        }
        }
    }
