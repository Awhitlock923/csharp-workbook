using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string input;

            int num = 0;

            int answer = 1;

            int i = num;
            //asks user to enter a number
            Console.Write("Enter your number: ");
            input = Console.ReadLine();
            //converts the user input from a string to an integer
            num = Convert.ToInt32(input);
            //if the number is greater than 0 then it multiplies if by the main number
            while( num > 0){
                answer = num * answer;
                num--;
            }

            Console.WriteLine(input+"! = "+ answer);
        }
    }
}
