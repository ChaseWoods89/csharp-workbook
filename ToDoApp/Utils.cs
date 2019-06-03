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
            Console.WriteLine("5. List Done Tasks");
            Console.WriteLine("6. Close Program");
            Console.WriteLine("");
            Console.WriteLine("Please select the number you want.");

            string menuResponse = getInput();

            if(menuResponse == "1"){

                Boolean exit = false;

                while(exit == false){
                Console.WriteLine("Please enter your task.");
                string userTask = getInput();
                
                dao.create(userTask, Status.Pending);
                foreach(Item i in dao.listPendingItems()){
                    string list = string.Format("{0}   {1}   {2}", i.id, i.task, i.status);
                    Console.WriteLine(list);

                }

                Console.WriteLine("Would you like to add another task? (yes or no)");

                string another = getInput().ToLower();
                
                
                if(another == "no"){
                    exit = true;
                }
                }
                printMenu();
            }

            else if(menuResponse == "2"){
                Boolean exit = false;
                while(exit == false){
                foreach(Item i in dao.listPendingItems()){
                    string list = string.Format("{0}   {1}   {2}", i.id, i.task, i.status);
                    Console.WriteLine(list);

                }
                Console.WriteLine("Which item would you like to mark done?");
                string doneItemId = getInput();
                int itemId = Convert.ToInt32(doneItemId);
                foreach(Item i in dao.listPendingItems()){
                    if(i.id == itemId){
                        dao.markDone(i);
                    }
                    else if(i.id != itemId){
                        printError();
                    }
                }
                Console.WriteLine("Would you like to mark another item done? (yes or no)");
                string another = getInput().ToLower();

                if(another == "no"){
                    exit = true;
                }
                else if(another != "no" && another != "yes"){
                    printError();
                }
                }
                printMenu();
                
            }
            if(menuResponse == "3"){
                foreach(Item i in dao.listPendingItems()){
                    string list = string.Format("{0}   {1}   {2}", i.id, i.task, i.status);
                    Console.WriteLine(list);
                }
                Console.WriteLine("");
                Console.WriteLine("Press enter to return to menu.");
                Console.ReadLine();
                printMenu();
            }
            else if(menuResponse == "4"){
                foreach(Item i in dao.listDoneItems()){
                    string list = string.Format("{0}   {1}   {2}", i.id, i.task, i.status);
                    Console.WriteLine(list);
                }
                Console.WriteLine("");
                Console.WriteLine("Press enter to return to menu.");
                Console.ReadLine();
                printMenu();
            }
            else if(menuResponse == "5"){
                foreach(Item i in dao.listAllItems()){
                    string list = string.Format("{0}   {1}   {2}", i.id, i.task, i.status);
                    Console.WriteLine(list);
                }
                Console.WriteLine("");
                Console.WriteLine("Press enter to return to menu.");
                Console.ReadLine();
                printMenu();
            }
            else if(menuResponse == "6"){
                Console.Clear();
                Console.WriteLine("Thank you! See you next time! (Press Enter to exit)");
                Console.ReadLine();
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
