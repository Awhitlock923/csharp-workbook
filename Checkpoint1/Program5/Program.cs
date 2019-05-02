using System;
using System.Collections.Generic;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter numbers: ");

            string input = Console.ReadLine();
            string[] arr = input.Split(',');
            List<int> nums = new List<int>();
            int oneNum;
            foreach(string s in arr)
            {
                if(Int32.TryParse(s, out oneNum))
                nums.Add(oneNum);
            }

            Console.WriteLine(nums);
        }
    }
}
