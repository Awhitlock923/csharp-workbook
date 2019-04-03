using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("My name is Austin.");
            Console.WriteLine("What is your name?");
            String yourName = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + yourName);
        }
    }
}
