using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp
{
    public class Utils
    {
                DAO dao = new DAO();
        public void printMenu() {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Task as Done");
            Console.WriteLine("3. List Pending Tasks");
            Console.WriteLine("4. List Done Tasks");
            Console.WriteLine("5. Close Program");
            Console.WriteLine("");
            Console.WriteLine("Please select the number you want.");

            string menuResponse = getInput();

            if(menuResponse == "1"){
                Console.WriteLine("Please enter your task.");

                Boolean exit = false;

                while(exit == true){
                string userTask = getInput();
                
                dao.create(userTask, Status.Pending);
                Console.WriteLine(dao.listPendingItems());

                Console.WriteLine("Would you like to add another task? (yes or no)");

                string another = getInput().ToLower();
                
                
                if(another == "no"){
                    exit = true;
                }
                printMenu();
                }


            }
            else if(menuResponse == "2"){
                Console.WriteLine(dao.listPendingItems());
                Console.WriteLine("Which item would you like to mark done?");
                string doneItemId = getInput();
                int itemId = Convert.ToInt32(doneItemId);

                

                
            }
            else if(menuResponse == "3"){
                Console.WriteLine(dao.listPendingItems());

            }
            else if(menuResponse == "4"){
                Console.WriteLine(dao.listDoneItems());
            }
            else if(menuResponse == "5"){
                
            }
            else{
                printError();
            }

        }

        public string getInput(){
            string userInput = Console.ReadLine();

            return userInput;
        }

        public string printError(){
            string errormessage = string.Format("You have entered an invalid input, please try again.");
            return errormessage;
        }
    }
}