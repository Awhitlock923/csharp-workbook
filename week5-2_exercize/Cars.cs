using System;
using System.Collections.Generic;

namespace Cars {
    public class Program {
        //program driver, has main

        public static void Main (String[] args) {
            CarLot jimmiesCars = new CarLot("Jimmys Cars");
            Car mazda = new Car ( /*Attributs go here */ );
            Car bmw = new Car ( /*Attributs go here */ );
            Truck f150 = new Truck ( /*Attributs go here */ );
            jimmiesCars.Add (mazda);
            jimmiesCars.Add (bmw);
            jimmiesCars.Add (f150);

            jimmiesCars.PrintInventory ();
        }
    }

    public class CarLot {

        //represents  a carlot
        List<Vehicle> inventory;
        string name;

        public void Add (Vehicle vehicle) {

        }

        public void PrintInventory () {
            //code goes here ....
        }
    }

    public abstract class Vehicle {
        //parent class that has common attributes of cars and trucks

        override
        public string ToString () {
            string s = " ";
            return s;
        }

        public string GetDescription () {

        }
    }

    public class Car : Vehicle {

    }

    public class Truck : Vehicle {

    }
}