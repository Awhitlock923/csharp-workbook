using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Black", "VW", "Jetta");
            // Console.WriteLine("c1 = {0}", c1.ToString());

            Car c2 = new Car("Blue", "Mazda", "3");
            // Console.WriteLine("c2 = {0}", c2.ToString());

            ParkingGarage p1 = new ParkingGarage(7);
            p1.parkCar(c1, 1);
            p1.towCar(1);
            p1.parkCar(c2, 1);
            
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

        public Car(String initialColor, string initialMake, string initialModel)
        {
            this.color = initialColor;
            this.make = initialMake;
            this.model = initialModel;
        }

        public String ToString(){
            string stringRepresentation = string.Format("{0} {1} {2}", this.color, this.make, this.model);
            return stringRepresentation;
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
