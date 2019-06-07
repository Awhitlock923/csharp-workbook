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
//start of the program
        public void start () {
            Utils.printStart ();
            string input = utils.getInput().ToUpper();
            if(input == "Y") {
                while (input != "DONE") {
                    Utils.printMenu ();
                    input = utils.getInput().ToUpper();
                    if (input == "1") {
                        Console.WriteLine ("Do you want to add a new item? (y) or (n)");
                        string answer = Console.ReadLine().ToUpper();
                        if (answer == "Y") {
                            processAdd ();
                        } else {
                            input = null;
                            continue;
                        }

                    } else if (input == "2") {
                        processChange ();
                    } else if (input == "3") {
                        Console.WriteLine ("Do you want to delete an item? (y) or (n)");
                        string answer = Console.ReadLine().ToUpper();
                        if (answer == "Y") {
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
            
            }else{
                utils.endMessage();
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
            int id = utils.selectID();
            dao.update(id);
            
        }

        public void processDelete () {
            dao.listItems();
            utils.deleteMessage();
            int id = utils.selectID();
            dao.delete(id);
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