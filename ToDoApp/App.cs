using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp
{
    class App
    {
        private DAO dao;
        private Utils utils;

        public App(){
            dao = new DAO();
            utils = new Utils();
        }
        static void Main(string[] args)
        {
            
            App app = new App();
            app.start();
            
            
        }

        public void start(){
            utils.printMenu();
            bool finish = false;
            while(finish == false){
            string menuResponse = utils.getInput();
            utils.clear();

            if(menuResponse == "1"){
                utils.clear();
                Boolean exit = false;

                while(exit == false){
                utils.printMsg("Please enter your task.");
                string userTask = utils.getInput();

                if(userTask == ""){
                utils.printError("You did not enter anything.");
                exit = true;
                }
                else{
                dao.create(userTask, Status.Pending);
                foreach(Item i in dao.listPendingItems()){
                    string list = string.Format("{0}   {1}   {2}", i.id, i.task, i.status);
                    utils.printMsg(list);

                }
                }

                utils.printMsg("Would you like to add another task? (yes or no)");

                string another = utils.getInput().ToLower();
                
                
                if(another == "yes"){
                    exit = false;
                }
                else if(another == "no"){
                    exit = true;
                }
                else{
                    utils.printError("You did not enter a valid answer. Please enter 'yes' or 'no'");
                    exit = true;
                
                }
                }
                utils.clear();
                utils.printMenu();
            }

            else if(menuResponse == "2"){
                utils.clear();
                Boolean exit = false;
                while(exit == false){
                
                foreach(Item i in dao.listPendingItems()){
                    string list = string.Format("{0}   {1}   {2}", i.id, i.task, i.status);
                    utils.printMsg(list);

                }
                utils.printMsg("Which item would you like to mark done?");
                string doneItemId = utils.getInput();
                int itemId;
                if(int.TryParse(doneItemId, out itemId)){

                utils.clear();
            
                foreach(Item i in dao.listPendingItems()){
                    if(i.id == itemId){
                        dao.markDone(i);
                    }
                }
                }
                else{
                    utils.printError("You did not enter a valid integer");
                    utils.getInput();
                    utils.clear();
                    exit = true;
                }
                    
                utils.printMsg("Would you like to mark another item done? (yes or no)");
                string another = utils.getInput().ToLower();

                if(another == "no"){
                    exit = true;
                }
                else if(another == "yes"){
                    exit = false;
                }
                else{
                    utils.printError("You have entered an invalid input");
                    exit = true;
                    
                }
                }
                utils.printMenu();
                
            }
            if(menuResponse == "3"){
                foreach(Item i in dao.listPendingItems()){
                    string list = string.Format("{0}   {1}   {2}", i.id, i.task, i.status);
                    utils.printMsg(list);
                }
                utils.printMsg("");
                utils.printMsg("Press enter to return to menu.");
                utils.getInput();
                utils.clear();
                utils.printMenu();
            }
            else if(menuResponse == "4"){
                foreach(Item i in dao.listDoneItems()){
                    string list = string.Format("{0}   {1}   {2}", i.id, i.task, i.status);
                    utils.printMsg(list);
                }
                utils.printMsg("");
                utils.printMsg("Press enter to return to menu.");
                utils.getInput();
                utils.clear();
                utils.printMenu();
            }
            else if(menuResponse == "5"){
                foreach(Item i in dao.listAllItems()){
                    string list = string.Format("{0}   {1}   {2}", i.id, i.task, i.status);
                    utils.printMsg(list);
                }
                utils.printMsg("");
                utils.printMsg("Press enter to return to menu.");
                utils.getInput();
                utils.clear();
                utils.printMenu();
            }
            
            else if(menuResponse == "6"){
                utils.clear();
                utils.printMsg("Thank you! See you next time! (Press Enter to exit)");
                utils.getInput();
                finish = true;
            }
                
            
            else{
                utils.printError("You did not enter a valid selection.");
                utils.printMenu();
            }
            }
}
}
}