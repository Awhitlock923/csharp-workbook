using System;

namespace To_Do_List {
    class Program {
        static void Main (string[] args) {
            App app = new App ();
            app.start ();
        }
    }

    public class App {
        Dao dao;
        Utils utils;

        public App () {
            dao = new Dao ();
            utils = new Utils ();
        }

        public void start () {
            Utils.printStart ();
            String input = utils.getInput ();
            if (input == "y") {
                while (input != "DONE") {
                    Utils.printMenu ();
                    input = utils.getInput ();
                    if (input == "1") {
                        Console.WriteLine ("Do you want to add a new item? (y) or (n)");
                        string answer = Console.ReadLine ();
                        if (answer == "y") {
                            processAdd ();
                        } else {
                            input = null;
                            continue;
                        }

                    } else if (input == "2") {
                        processChange ();
                    } else if (input == "3") {
                        Console.WriteLine ("Do you want to delete an item? (y) or (n)");
                        string answer = Console.ReadLine ();
                        if (answer == "y") {
                            processDelete ();
                        } else {
                            input = null;
                            continue;
                        }
                    } else if (input == "4"){
                        showCompletedItems();
                    } else if (input == "5"){
                        showIncompletedItems();
                    }

                }
            } else {
                utils.endMessage ();
            }

        }

        public void processAdd () {
            utils.addName ();
            string newName = Console.ReadLine ();
            dao.create (newName, Status.Incomplete);
            foreach(Items i in dao.listItems())
            {
            Console.WriteLine(i.id+" | "+ i.name+" | " + i.status);
            }
        }

        public void processChange () {
            foreach(Items i in dao.listItems())
            {
            Console.WriteLine(i.id+" | "+ i.name+" | " + i.status);
            }
            utils.selectID();
            
            dao.update();
            
        }

        public void processDelete () {
            dao.listItems();
            utils.deleteMessage ();
            dao.delete();
            foreach(Items i in dao.listItems())
            {
            Console.WriteLine(i.id+" | "+ i.name+" | " + i.status);
            }
        }

        public void showIncompletedItems(){
            foreach(Items a in dao.listIncompleteItems())
            {
            Console.WriteLine(a.id+" | "+ a.name+" | " + a.status);
            }
        }

        public void showCompletedItems(){
            foreach(Items b in dao.listCompleteItems())
            {
            Console.WriteLine(b.id+" | "+ b.name+" | " + b.status);
            }
        }
    }
}