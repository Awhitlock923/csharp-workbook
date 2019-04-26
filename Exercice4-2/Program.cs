using System;
using System.Collections.Generic;

namespace Exercice4_2 {
    class Program {
        static void Main (string[] args) {

            List<Person> people = new List<Person> ();

            for (int i = 0; i < 3; i++) {
                Person x = new Person ();

                Console.WriteLine ("Please Type your first name.");
                x.fName = Console.ReadLine ();

                Console.WriteLine ("Please enter last name.");
                x.lName = Console.ReadLine ();

                Console.WriteLine ("Enter the date of birth.");
                x.dob = Console.ReadLine ();

                people.Add (x);
            }

            for (int i = 0; i < people.Count; i++) {
                Person w = people[i];
                string fullName = Person.staticFullName (w.fName, w.lName);
                Console.WriteLine ("Hello " + fullName + " " + " you were born on " + w.dob);

            }

        }

        
    }

    class Person {
        public string fName;
        public string lName;
        public string dob;

        public static string staticFullName (string f, string l) {
            string full = f + " " + l;
            return full;
        }

        public string nonStaticFullName(){
            return this.fName+" "+this.lName;
        }
    }
}