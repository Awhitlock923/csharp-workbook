using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            // string rock = "rock";
            // string paper = "paper";
            // string scissors = "scissors";
            Console.WriteLine("0 = Rock");
            Console.WriteLine("1 = Paper");
            Console.WriteLine("2 = Scissors");
            Console.WriteLine("Enter 0, 1, or 2 for hand 1:");
            int hand1 = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int hand2 = rnd.Next(0,3);
            
            Console.WriteLine("user: "+ hand1+ " / Cpu: " +hand2);

            if(hand1 == hand2){
                Console.WriteLine("its a tie");
            }else if(hand1 == 0 && hand2 == 2){
                Console.WriteLine("User wins");
            }else if(hand1 == 1 && hand2 == 0){
                Console.WriteLine("User wins");
            }else if(hand1 == 2 && hand2 == 1){
                Console.WriteLine("User wins");
            }else{
                Console.WriteLine("CPU wins");
            }

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            return hand1;


        }
    }
}
