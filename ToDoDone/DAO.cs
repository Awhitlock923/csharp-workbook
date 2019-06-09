using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;




namespace To_Do_List {

    
    public enum Status { 
        Incomplete, 
        Complete }
//
    public class Dao {
        private ItemsContext context;

        public Dao () {
            context = new ItemsContext ();
            context.Database.EnsureCreated ();
            
        }

        public void create(string name, Status status) {
            Items newItems = new Items (name, status);
            context.items.Add (newItems);
            context.SaveChanges();
        }

        public void update(int id){
            foreach(Items i in context.items)
            {
                if(i.id == id){
                      i.status = Status.Complete;
                }else{
                    continue;
                }
            }
            context.SaveChanges();
        }
//deletes an item
        public void delete(int id) {
            context.items.Remove(context.items.Find(id));
            context.SaveChanges();
        }

        public List<Items> listItems() {
            List<Items> items = new List<Items> ();
            foreach (Items i in context.items) {
                items.Add (i);
            }
            return items;
        }

        public List<Items> listCompleteItems()
            {
                List<Items> Complete = new List<Items>();
                foreach(Items b in context.items)
                {
                    if(b.status == Status.Complete){
                        Complete.Add(b);
                    }
                }
                return Complete;
            }

        public List<Items> listIncompleteItems()
            {
                List<Items> Inomplete = new List<Items>();
                foreach(Items a in context.items)
                {
                    if(a.status == Status.Incomplete){
                        Inomplete.Add(a);
                    }
                }
                return Inomplete;
            }

    }
    public class ItemsContext : DbContext {
        public DbSet<Items> items { get; private set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite ("Filename=./Items.db");
        }
    }

}