using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace week9_2ex
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Austin = new Person("Austin", Gender.Male);
            Person mom = new Person("Barb", Gender.Female);
            Person dad = new Person("Jason", Gender.Male);
            // Person siblings = new Person("Machaela", Female);
            // Person siblings = new Person("Jack", Male);

            Austin.mom = mom;
            Austin.dad = dad;

            Console.WriteLine(Austin);
            Console.WriteLine(Austin.dad);
            Console.WriteLine(Austin.mom);

            PersonContext context = new PersonContext();
            context.Database.EnsureCreated();
            context.persons.Add(Austin);
            context.SaveChanges();
            context.persons.Add(mom);
            context.SaveChanges();
            context.persons.Add(dad);
            context.SaveChanges();
        }

    }

    public class Person
    {
        public int id {get; private set;}
        public string name{get; set;}

        public int momid{get; set;}
        virtual public Person mom{get; set;}

        public int dadid{get; set;}
        virtual public Person dad{get; set;}

       public List<Person> siblings = new List<Person>();

        public Gender gender;

        public Person(string iName, Gender iGender){
            this.name = iName;
            this.gender = iGender;
        }
        public Person()
        {}

        override public String ToString(){
            return String.Format("{0}", this.name);
        }
    }

    public enum Gender{Male, Female, Other}


    public class PersonContext : DbContext
    {
        public DbSet<Person> persons{get; private set;}
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./family.db");
        }
    }
}
