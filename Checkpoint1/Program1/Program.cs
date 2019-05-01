using System;


namespace Checkpoint1
{
    class Program1
    {
        static void Main(string[] args)
        {

            int count = 0;
            int three = 3;

            int[] num = new int[100];
            
            int i = 1;

            while( i < 101){
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

