using System;
using System.Collections.Generic;

namespace week6_2_exer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bigBlue = new Car("Big Blue", 102.4);
            Car herby = new Car("Herby", 40);
            Car delorian = new Car("Delorian", 88);
            Car mysterMachine = new Car("Mystery Machine", 102.5);
            Person bob = new Person("Bob", 20);

            List<IRace> racers = new List<IRace>();
            racers.Add(bigBlue);
            racers.Add(herby);
            racers.Add(delorian);
            racers.Add(mysterMachine);
            racers.Add(bob);

            foreach(IRace racer1 in racers)
            {
                foreach(IRace racer2 in racers)
                {
                    IRace winner = Race(racer1, racer2);
                    Console.WriteLine("{0} vs {1} = {2}", racer1, racer2, winner.getCelebrateMessage());
                }
            }

            
        }
    
        public static IRace Race(IRace r1, IRace r2)
        {
            if(r1.getSpeedMPH()  > r2.getSpeedMPH()){
                return r1;
            }else{
                return r2;
            }
        }
    }

    public interface IRace
    {
        double getSpeedMPH();
        string getCelebrateMessage();
    }

    public class Car : IRace
    {
        public string name {get; private set;}
        public double speedMPH {get; private set;}

        public Car(String initialName, double initialSpeed)
        {
            this.name = initialName;
            this.speedMPH = initialSpeed;
        }

        override
        public String ToString()
        {
            String s = String.Format("{0} ({1})", this.name, this.speedMPH);
            return s;
        }

        public double getSpeedMPH()
        {
        return this.speedMPH;
        }

        public string getCelebrateMessage()
        {
            String s = String.Format("Beep Beep!");
            return s;
        }
    }

    public class Person : IRace
    {
        public string name {get; private set;}
        public double speedMPM;

        public Person(String initialName, double initialSpeed)
        {
            this.name = initialName;
            this.speedMPM = initialSpeed;
        }

        override
        public String ToString()
        {
            String s = String.Format("{0} ({1})", this.name, this.speedMPM);
            return s;
        }

        public double getSpeedMPH()
        {
            //convert from meters / minute
            return speedMPM * 60 / 1609.34;
        }

        public string getCelebrateMessage()
        {
            String s = String.Format("Thank you, I worked hard for this!");
            return s;
        }
    }
}
