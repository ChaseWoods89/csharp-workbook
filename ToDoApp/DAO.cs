using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp
{
    class DAO
    {
     private ItemsContext context;


     public DAO()
     {
         context = new ItemsContext();
         context.Database.EnsureCreated();
     }   

     public void create(string task, Status status){
         Item newItem = new Item(task, status);
         context.items.Add(newItem);
         context.SaveChanges();
         
     }
     public void markDone(Item item){
         item.status = Status.Done;
         context.SaveChanges();

     }
     public List<Item> listAllItems(){
         List<Item> allItem = new List<Item>();
         foreach(Item i in context.items){
             allItem.Add(i);
         }
         return allItem;
     }
      public List<Item> listPendingItems()
     {
         List<Item> pendingItem = new List<Item>();
         foreach(Item i in context.items)
         {
             if(i.status == Status.Pending){
                 pendingItem.Add(i);
             }
         }
         return pendingItem;
     }
     public List<Item> listDoneItems()
     {
         List<Item> markedDone = new List<Item>();
         foreach(Item i in context.items)
         {
             if(i.status == Status.Done){
                 markedDone.Add(i);
             }
         }
         return markedDone;
     }

     /* 
     public override string ToString(){
         string printedList = string.Format("{0}   {1}   {2}", 
     }
     */
    }
    public class ItemsContext : DbContext
            {
                public DbSet<Item> items {get; private set;}
                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                    optionsBuilder.UseSqlite("Filename=./todo.db");
                }
            }        
}