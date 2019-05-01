using System;

namespace Program2
{
    class Program2
    {
        int num;
        int sum = 0;
        int i = 0;
        string ok = "ok";
        string input;

        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            string input;

            Console.WriteLine("Type out your numbers and type ok when finished");

            
                Console.Write("User input: ");
                input= Console.ReadLine();

               while(input != "ok" || input != "OK"){
                
                num = Convert.ToInt32(input);

                sum = num + sum;

                Console.Write("User input: ");
                input= Console.ReadLine();

               }

               Console.WriteLine("The sum of your numbers is: " + sum);

            


            
        }

        
    }
}
