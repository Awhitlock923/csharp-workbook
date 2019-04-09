using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

namespace FunctionTest
{
    
    class PigLatinClass
    {
        static void Main(){

        
        
            // your code goes here
            

            
                
                    string sentence;
                    string firstLetter;
                    string afterFirst;
                    string pigLatinOut = "";
                    int x;
                    string vowel = "AEIOUaeiou";

                    Console.WriteLine("Enter a sentence to convert into PigLatin");

                    sentence = Console.ReadLine();

                    string[] pieces = sentence.Split();

                    foreach (string piece in pieces)
                    {
                        afterFirst = piece.Substring(1);
                        firstLetter = piece.Substring(0, 1);
                        x = vowel.IndexOf(firstLetter);

                        if (x == -1)
                        {
                            pigLatinOut = (afterFirst + firstLetter + "ay ");
                        }
                        else
                        {
                            pigLatinOut = (firstLetter + afterFirst + "yay ");
                        }

                        Console.Write(pigLatinOut);
                    }

                    Console.WriteLine("Press Enter to flip the sentence back.");
                    Console.ReadKey(true);
                    string clonedString = null;
                    clonedString = (String)sentence.Clone();
                    Console.WriteLine(clonedString);
                }
        }
            
                // leave this command at the end so your program does not close automatically
    }

        

        


