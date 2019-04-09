using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("My name is Austin.");
            // Console.WriteLine("What is your name?");
            // String yourName = Console.ReadLine();
            // Console.WriteLine("Nice to meet you " + yourName);

            int num1 = 0;
            int num2 = 0;
            

            Console.WriteLine("What is your first number?");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the second number?");
            num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Your answer is " + sum);

            int yards = 0;
            
            Console.WriteLine("How many yards would you like to convert to inches?");
            yards = Convert.ToInt32(Console.ReadLine());
            int inches = yards * 36;
            Console.WriteLine("Your answer is " + inches + " inches.");

            bool people = true;
            bool f = false;
            double num = 1.5;

            Console.WriteLine("");
            Console.WriteLine("num * num is: " + num * num);

            String firstName = "Austin";
            String lastName = "Whitlock";
            int age = 21;
            String job = "Ikea food";
            String favoriteBand = "AJR";
            String favoriteSportsTeam = "Cubs";


            Console.WriteLine("Hi! my name is "+ firstName+ " "+ lastName+" I am " + age + " years old. I work at "+ job + ". My favorite band is "+ favoriteBand+ ". My favorite sport is the Chicago "+ favoriteSportsTeam+ ".");
        }
    }
}
