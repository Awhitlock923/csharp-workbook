using System;

namespace Program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int num;
            int sum = 0;
            int i = 0;
            string ok = "ok";

            Console.WriteLine("Type a number to add or type ok to finish and end the program.");
                string input = Console.ReadLine();

            do{

                
                num = Convert.ToInt32(input);
                sum = num + sum;

            }while(input == ok);


            
        }
    }
}
