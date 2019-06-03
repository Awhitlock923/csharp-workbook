using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace week9_1ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // book:
            // id:
            // title:
            // type:

            //Author:
            //id:
            //name:

            Dao dao = new Dao();
            dao.create("Cat in the Hat", Type.Kids);
            dao.create("The Hobbit", Type.Fiction);

            foreach(Book b in dao.listbooks())
            {
            Console.WriteLine(b.title+" is a "+ b.type+" Book");
            }
        }

        public class Book
        {
            public int id {get; private set;}
            public string title {get; private set;}
            public Type type {get; private set;}

            public Book()
            {
                
            }

            public Book(string iTitle, Type iType)
            {
                this.title = iTitle;
                this.type = iType;
            }
            
        }

        public enum Type{Fiction, Kids, Bio}

        public class Dao
        {
            private BooksContext context;

            public Dao()
            {
                context = new BooksContext();
                context.Database.EnsureCreated();
                
            }

            public void create(string title, Type type)
            {
                Book newBook = new Book(title, type);
                context.books.Add(newBook);
                context.SaveChanges();
            }

            public List<Book> listbooks()
            {
                List<Book> result = new List<Book>();
                foreach(Book b in context.books)
                {
                    result.Add(b);
                }
                return result;
            }

            public List<Book> listfictionbooks()
            {
                List<Book> fiction = new List<Book>();
                foreach(Book b in context.books)
                {
                    if(b.type == Type.Fiction)
                    {
                        fiction.Add(b);
                    }
                }
                return fiction;
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

        

       

        // public class Author{
        //     public int id;
        //     public string name;
        // }
    }
}
