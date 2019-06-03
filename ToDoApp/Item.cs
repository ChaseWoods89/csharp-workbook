using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp
{
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

    public enum Status 
    {
        Pending, Done
    }
}