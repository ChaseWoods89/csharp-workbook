using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace week9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DAO dao = new DAO();
            bool exit = false;
            while (exit == false){

            Console.WriteLine("Please enter a book title or enter exit to finish.");
            string userInput1 = Console.ReadLine();

            if (userInput1 == "exit" || userInput1 == "Exit") {
                exit = true;
            }
            Console.WriteLine("What Genre is the book? (Kids, Fiction, Biography)");
            string userInput2 = Console.ReadLine().ToLower();

            if (userInput2 == "kids") {
                dao.create(userInput1, Type.Kids);
            }
            else if (userInput2 == "fiction"){
                dao.create(userInput1, Type.Fiction);
            }
            else if (userInput2 == "biography"){
                dao.create(userInput1, Type.Fiction);
            }
            }

            foreach (Book b in dao.listBooks())
            {
                Console.WriteLine(b.name + " is in the " + b.type + " genre of books.");
            }   
        }
    }

    public class Book 
    {
        public int id {get; private set;}
        public string name {get; private set;}
        public Type type {get; private set;}
        public Book()
        {        
        }
        public Book( string intialName, Type initialType){
            this.name = intialName;
            this.type = initialType;
            
        }
    }
        public enum Type
        {
            Fiction, Kids, Biography
        }

    public class DAO
    {
        //this class manages the data access to books
        private BooksContext context;
        //creates a new instance of dao
        public DAO()
        {
            context = new BooksContext();
            context.Database.EnsureCreated();
        }
        //create coresponding book and store it.
        public void create(string name, Type type)
        {
            Book newBook = new Book(name, type);
            context.books.Add(newBook);
            context.SaveChanges();
        }
        //return the current list of books
        public List<Book> listBooks()
        {
             List<Book> result = new List<Book>();
             foreach (Book b in context.books){
                 result.Add(b);
                 }
                 return result;
        }

        public List<Book> listFictionBooks()
        {
            List<Book> fictionBooks = new List<Book>();
            foreach(Book b in context.books){
                if (b.type == Type.Fiction){
                    fictionBooks.Add(b);
                }
            }

                return fictionBooks;
            }

            public class BooksContext : DbContext
            {
                public DbSet<Book> books {get; private set;}
                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                    optionsBuilder.UseSqlite("Filename=./books.db");
                }
            }        
            }
    }