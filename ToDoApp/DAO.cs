using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp
{
    class DAO
    {
     private ItemsContext context;

    //DAO does not need to interact with Utils
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
     public void delete(Item item){
         context.items.Remove(item);
         context.SaveChanges();
         //delete and create were extremely similar, luckily that worked out
     }
     public void markDone(Item item){
         item.status = Status.Done;
         context.SaveChanges();
        //Markdone felt too simple, turns out i was right.
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
         //Decided to have methods for all item listings.
     }
    //originally was going to do a ToString, luckily i figured it out and also this wouldn't have been the place for it.
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