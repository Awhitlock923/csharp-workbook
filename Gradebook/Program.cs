using System;
using System.Collections.Generic;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args) {
        

            // write a program that asks the user for 5 integers.
            // handle the user giving you non-integer input.

            Dictionary<String,String> studentList = new Dictionary<String,String>();
            Console.WriteLine("Students first");
            studentList.Add(Console.ReadLine(),Console.ReadLine());
            Console.WriteLine(studentList);

            studentList.Add("","");
            studentList.Add("", "");



            // looping through the keys of my dictionary
            foreach(String student in studentList.Keys) {
                Console.WriteLine(student);

                // for every key, i want the value
                String grades = studentList[student];
                Console.WriteLine("The grade of {0} is {1}", student, grades);
            }

            // looping through the entries in my dictionary
            
        }    

        
    }
}
