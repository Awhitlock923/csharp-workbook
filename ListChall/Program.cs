using System;

namespace ListChall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            string input = Console.ReadLine();

            try
            {
                int num = Convert.ToInt32(input);
                Console.WriteLine("The square of the number is " + (num * num));
            }catch(Exeption e)
            {
                Console.WriteLine("something went wrong.....");
                Console.WriteLine("the message from the exception is " + e.Message);
            }
            finally
            {
                Console.WriteLine("Thanks for playing.");
            }
            

            
        }
    }
}
