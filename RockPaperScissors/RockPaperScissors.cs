using System;

namespace RockPaperScissors
{
    class Program
    {

        

        public static void Main()
        {
            string hand1;
            // string rock = "rock";
            // string paper = "paper";
            // string scissors = "scissors";
            Console.WriteLine("Rock");
            Console.WriteLine("Paper");
            Console.WriteLine("Scissors");
            
                    Console.WriteLine("Enter hand 1:");
                    hand1 = Console.ReadLine();
            
                if(hand1 == "rock" || hand1 == "ROCK"){
                    hand1 = "Rock";
                }else if(hand1 == "paper" || hand1 =="PAPER"){
                    hand1 = "Paper";
                }else if(hand1 == "scissors" || hand1 == "SCISSORS"){
                    hand1 = "Scissors";
                }

            Random rnd = new Random();
            int num = rnd.Next(0,3);

            string hand2 = "";
            
            
            if(num == 0){
                hand2 = "Rock";
            }else if(num == 1){
                hand2 = "Paper";
            }else if(num == 2){
                hand2 = "Scissors";
            }
            
            
            
            Console.WriteLine("user: "+ hand1+ " / Cpu: " +hand2);

            try{
            CompareHands(hand1, hand2);
            } catch (InvalidCastException e){
                Console.WriteLine("Invalid word", e);
            }
            
            
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            
            

            
                
            
            if(hand1 == "Rock" ||  hand1 == "Paper" || hand1 == "Scissors"){
                
            
            // Your code here
                    if(hand1 == hand2){
                        Console.WriteLine("its a tie");
                    }else if(hand1 == "Rock" && hand2 == "Scissors"){
                        Console.WriteLine("User wins");
                    }else if(hand1 == "Paper" && hand2 == "Rock"){
                        Console.WriteLine("User wins");
                    }else if(hand1 == "Scissors" && hand2 == "Paper"){
                        Console.WriteLine("User wins");
                    }else{
                        Console.WriteLine("CPU wins");
                    }
                    return hand1;

            }else{
                throw new InvalidCastException();
            }
            
             
            

            
        }
    }
}
