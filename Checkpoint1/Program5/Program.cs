using System;
using System.Collections.Generic;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;

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

            for(int i = 0; i < arr.Length; i++){
                
                if(max < nums[i]){
                    max = nums[i];
                }
            }
            Console.WriteLine("The largest number is "+max);
        }
    }
}
