using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] num = {1,2,3,4,5,6,7,8,9,
            10,11,12,13,14,15,16,17,18,19,
            20,21,22,23,24,25,26,27,28,29,
            30,31,32,33,34,35,36,37,38,39,
            40,41,42,43,44,45,46,47,48,49,
            50,51,52,53,54,55,56,57,58,59,
            60,61,62,63,64,65,66,67,68,69,
            70,71,72,73,74,75,76,77,78,79,
            80,81,82,83,84,85,86,87,88,89,
            90,91,92,93,94,95,96,97,98,99,100};

            int i = 0;
            int three = 3;
            int five = 5;

            string fizzBuzz = "FIZZBUZZ";
            string Fizz = "FIZZ";
            string Buzz = "BUZZ";

            while(i < num.Length){
                // Console.WriteLine("hi");
                if(num[i] % three == 0 && num[i] % five == 0){
                    Console.WriteLine(fizzBuzz);
                    i++;
                }else if(num[i] % three == 0){
                    Console.WriteLine(Fizz);
                    i++;
                }else if(num[i] % five == 0){
                    Console.WriteLine(Buzz);
                    i++;
                }else{
                    Console.WriteLine(num[i]);
                    i++;
                }
            }
        }
    }
}
