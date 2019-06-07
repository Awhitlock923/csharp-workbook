using System;

namespace To_Do_List {
    public class Utils {
        public static void printStart(){
            Console.WriteLine("Do you wnat to run the app? (y) or (n)");
        }

        public static void printMenu() {
            Console.WriteLine("Press (1) to add item;");
            Console.WriteLine("Press (2) to change status of item.");
            Console.WriteLine("Press (3) to delete item.");
            Console.WriteLine("Press (4) to show completed items.");
            Console.WriteLine("Press (5) to show incompleted items.");
            Console.WriteLine("Type DONE to finish and exit.");
        }

        public string Error = "Invalid entry.";

        public string getInput(){
            string getInput = Console.ReadLine();
            // if(getInput == "1" || getInput == "2" || getInput == "3" || getInput == "4" || getInput == "5" || getInput == "DONE"){
            // return getInput;
            // }else{
                // return Error;
            // }
            return getInput;
        }
//
        public void emessage(){
            Console.WriteLine("Invalid entry.");
        }


        public void addName(){
            Console.WriteLine("Enter the item name.");
        }

        public int selectID(){
            Console.WriteLine("Enter ID of item you want to change the status to.");
            int ID = Convert.ToInt32(Console.ReadLine());
            return ID;
        }


        public void deleteMessage(){
            Console.WriteLine("Enter the ID number of your item.");
            int ID = Convert.ToInt32(Console.ReadLine());
        }

        public void endMessage(){
            Console.WriteLine("Thank you for stopping by.");
        }

        
    }
}