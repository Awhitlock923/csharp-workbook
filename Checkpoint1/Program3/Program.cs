using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;

            int num = 0;

            int answer = 1;

            int i = num;

            Console.Write("Enter your number: ");
            input = Console.ReadLine();

            num = Convert.ToInt32(input);

            while( num > 0){
                answer = num * answer;
                num--;
            }

            Console.WriteLine(input+"! = "+ answer);
        }
    }
}
