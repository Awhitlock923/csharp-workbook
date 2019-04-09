using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // string userName= "";

            // Console.WriteLine("Hello user what is your name?");
            // userName = Console.ReadLine();

            // Console.WriteLine("Hello "+ userName +" how are you today?");

        
            double money= 389.92;
            int cha100;
            int cha50;
            int cha20;
            int cha10;
            int cha5;
            int cha1;
            double cha50c;
            double cha25c;
            double cha10c;
            double cha5c;
            double cha1c;

            cha100 = money / 100;
            money = money - cha100;
            cha50 = money / 50;
            money = money - cha50;
            cha20 = money / 20;
            money = money - cha20;
            cha10 = money / 10;
            money = money - cha10;
            cha5 = money / 5;
            money = money - cha5;
            cha1 = money / 1;
            money = money - cha1;
            cha50c = money / .5;
            money = money - cha50c;
            cha25c = money / .25;
            money = money - cha25c;
            cha10c = money / .10;
            money = money - cha10c;
            cha5c = money / .05;
            money = money - cha5c;
            cha1c = money / .01;
            money = money - cha1c;
            
            

            Console.WriteLine("The breakdown of 389.92 is: " + change100 + change50 + change20 + change10 + change5 + change1 + change50c + change25c + change10c + change5c + change1c);
        }
    }
}
