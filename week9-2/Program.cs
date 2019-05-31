using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace week9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person hank = new Person();
            hank.mom = null;
            hank.dad = null;
            hank.name = "Hank Hill";
            hank.gender = Gender.Male;

            Person peggy = new Person();
            peggy.mom = null;
            peggy.dad = null;
            peggy.name = "Peggy Hill";
            peggy.gender = Gender.Female;

            Person bobby = new Person();
            bobby.dad = hank;
            bobby.mom = peggy;
            bobby.gender = Gender.Male;
            bobby.name = "Bobby Hill";

            Console.WriteLine(bobby.name);
            Console.WriteLine(bobby.dad.name);
            Console.WriteLine(bobby.mom.name);

            PersonContext context = new PersonContext();
            context.Database.EnsureCreated();

            context.persons.Add(hank);
            context.SaveChanges();
            context.persons.Add(peggy);
            context.SaveChanges();
            context.persons.Add(bobby);
            context.SaveChanges();

        }
    }

    public class Person
    {
       public int id {get; private set;}
       public string name {get; set;}
       public int momId {get; set;}
       public virtual Person mom {get; set;}
       public int dadId{get; set;}
       public virtual Person dad {get; set;}
       public List<Person> siblings;
       public Gender gender{get; set;}


      public Person(){}

      public override string ToString()
      {
          return String.Format("{0}", this.name);
      }

        /*Person(string iName, Person iMom, Person iDad, 
        List<Person> iSiblings, Gender iGender) {
            this.name = iName;
            this.mom = iMom;
            this.dad )= iDad;
            this.siblings = iSiblings;
            this.gender = iGender;
        }*/
    }
    public enum Gender 
    {
        Male, Female, Other
    }
    public class PersonContext : DbContext 
    {
        public DbSet<Person> persons {get; private set;}
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./family.db");
        }
    }
}
