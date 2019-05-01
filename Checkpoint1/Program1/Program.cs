using System;


namespace Checkpoint1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int count = 0;
            int three = 3;

            int[] num = new int[100];
            
            int i = 1;

            //runs loop if the number is less than 101
            while( i < 101){
                //checks numbers if they are divisible by three
                if(i % three == 0){
                    Console.WriteLine("yes");
                    count++;
                    i++;
                }else{
                    Console.WriteLine(i);
                }
                i++;
            }
            
            Console.WriteLine("There are " + count + " numbers divisible by three between 1 and 100.");


        }
    }
}

