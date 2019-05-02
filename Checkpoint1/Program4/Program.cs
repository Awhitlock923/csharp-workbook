using System;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //generates a random number for the computer
            Random rnd = new Random();
            int num = rnd.Next(0,10);
            
            string input;

            int turns = 2;
            int x = 3;
            Console.WriteLine(num);
            

            //loops three times to check to see if you can guess the computers random number
            while( x > 0){
                Console.Write("Guess the number:");
                input = Console.ReadLine();

                int i = Convert.ToInt32(input);
            
                if(i == num){
                    Console.WriteLine("You Win!");
                }else{
                    Console.WriteLine("Amount of tries left: "+ turns);
                }
                turns--;
                x--;
            }
        }
    }
}
