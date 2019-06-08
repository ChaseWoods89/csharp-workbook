using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp
{
    //Model class or "Entity"
    public class Item
    {
        public int id {get; private set;}
        public string task {get; set;}
        public Status status {get; set;}
        public Item()
        {
        }
        public Item(string iTask, Status iStatus){
            this.task = iTask;
            this.status = iStatus;
        }
        
    }
        //went with an enum over a bool because I like the functionality of enums more. made creating methods in
        //DAO much easier.
    public enum Status 
    {
        Pending, Done
    }
}