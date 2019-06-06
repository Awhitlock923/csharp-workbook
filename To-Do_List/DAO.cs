using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;




namespace To_Do_List {

    
    public enum Status { 
        Incomplete, 
        Complete }

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

        public void update(Items i){
            context.items.Find(ItemsID);
            context.ItemsID.status = Status.Completed;
            context.SaveChanges();
        }

        public void delete() {
            context.items.Remove(context.items.Find(idRemove);
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