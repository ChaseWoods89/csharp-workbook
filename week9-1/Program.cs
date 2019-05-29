using System;
using System.Collections.Generic;

namespace week9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DAO dao = new DAO();
            dao.create("Lord of the Rings", Type.Fiction);
            dao.create("Hop on Pop", Type.Kids);
            dao.create("Theory of Everything", Type.Biography);

            foreach (Book b in dao.listBooks())
            {
                Console.WriteLine(b.name + " is in the " + b.type + " genre of books.");
            }   
        }
    }

    public class Book 
    {
        public int id;
        public string name;
        public Type type;

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
        private List<Book> books;
        //creates a new instance of dao
        public DAO()
        {
            books = new List<Book>();
        }
        //create coresponding book and store it.
        public void create(string name, Type type)
        {
            Book newBook = new Book(name, type);
            books.Add(newBook);
        }
        //return the current list of books
        public List<Book> listBooks()
        {
             List<Book> result = new List<Book>();
             foreach (Book b in books){
                 result.Add(b);
                 }
                 return result;
        }

        public List<Book> listFictionBooks()
        {
            List<Book> fictionBooks = new List<Book>();
            foreach(Book b in books){
                if (b.type == Type.Fiction){
                    fictionBooks.Add(b);
                }
            }

                return fictionBooks;
            }
        }
    }