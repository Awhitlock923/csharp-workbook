using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Passengers x1 = new Passengers("John Doe", "Jane Doe");

            Passengers x2 = new Passengers("Mark Freeman", "Rose Freeman");

            Passengers x3 = new Passengers("Bob Smith", "Julia Smith");

            Car c1 = new Car("Black", "VW", "Jetta");
            // Console.WriteLine("c1 = {0}", c1.ToString());

            Car c2 = new Car("Blue", "Mazda", "3");
            // Console.WriteLine("c2 = {0}", c2.ToString());

            Car c3 = new Car("Yellow", "Cheverle", "Camaro");

            c1.seats(x1, 1);
            c2.seats(x2, 1);
            c3.seats(x3, 1);

            ParkingGarage p1 = new ParkingGarage(7);
            p1.parkCar(c1, 1);
            // p1.towCar(1);
            p1.parkCar(c2, 2);
            p1.parkCar(c3, 3);
            
        }
    }



    public class Passengers
    {
        public string nameOne;
        public string nameTwo;

        public Passengers(string initialNameOne, string initialNameTwo)
        {
            this.nameOne = initialNameOne;
            this.nameTwo = initialNameTwo;
        }

        public String ToString(){
            string stringRepresentation = string.Format("{0} {1}", this.nameOne, this.nameTwo);
            return stringRepresentation;
        }
    }



    // represent a car as a class.
    // represent a parking garage as a class
    // we want to use our paking garage class, to manage our inventory.



    public class Car
    {
        public string make {get; private set;}
        public string model {get; private set;}
        public string color;
        public string plateNumber;
        public int year;

        private Passengers[]  availableSeats;

        public Car(string initialColor, string initialMake, string initialModel)
        {
            this.color = initialColor;
            this.make = initialMake;
            this.model = initialModel;
        }

        public String ToString(){
            string stringRepresentation = string.Format("{0} {1} {2}", this.color, this.make, this.model);
            return stringRepresentation;
        }

        public Car(int desiredNumberOfSeats)
        {
            availableSeats = new Passengers[desiredNumberOfSeats];
        }

        public bool isSeatAvailable(int seatNumber){
            Passengers thePeopleInTheSeats = availableSeats[seatNumber];
            if(availableSeats[seatNumber] == null){
                return true;
            }else{
                return false;
            }
        }

        public void seats(Passengers people, int seats)
        {
            bool isSeatEmpty = isSeatAvailable(seats);
            if(isSeatEmpty == true)
            {
            // bad parking garage did not actually park my car ....
            this.availableSeats[seats]= people;
            }else{
                throw new Exception("Slot "+seats+" is taken!");
            }
        }

    }

    public class ParkingGarage
    {
        public int numSpaces {get; private set;}
        private Car[] parkingSlots;

        public ParkingGarage(int desiredNumberOfSlots)
        {
            parkingSlots = new Car[desiredNumberOfSlots];
        }

        //This method should return true, if the slot is available
        //otherwise should return false
        public bool isSlotAvailable(int slotNumber){
            Car theCarInTheSlot = parkingSlots[slotNumber];
            if(parkingSlots[slotNumber] == null){
                return true;
            }else{
                return false;
            }
        }

        public void parkCar(Car theCar, int theSlot)
        {
            bool isSlotEmpty = isSlotAvailable(theSlot);
            if(isSlotEmpty == true)
            {
            // bad parking garage did not actually park my car ....
            this.parkingSlots[theSlot]= theCar;
            }else{
                throw new Exception("Slot "+theSlot+" is taken!");
            }
        }

        public Car towCar(int theSlot)
        {
            Car c = parkingSlots[theSlot];
            parkingSlots[theSlot] = null;

            return c;
        }
    }
}
