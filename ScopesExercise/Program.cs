using System;

namespace ScopesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] students = new String[]{"John", "Jane", "Matt"};
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(i+" => "+ students[i]);
                
            }

            
        }

    }
}

