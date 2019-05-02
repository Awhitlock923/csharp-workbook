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
            Console.WriteLine("Hello World!");
            int num;
            int sum = 0;
            string input;

            Console.Write("Type out your numbers and type ok when finished");

            foreach(){
                Console.Write("User input: ");
                input= Console.ReadLine();

                if(input == "ok"){
                    Console.WriteLine("your numbers add up to be: ");
                }else{
                    num = Convert.ToInt32(input);

                    sum = num + sum;
                }

            }


            
        }

        
    }
}
