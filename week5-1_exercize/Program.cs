using System;

namespace week5_1_exercize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class Person
    {
        public char gender;
        public string name;


        public Person(bool x){
            if(x){
                this.name= "Jane Doe";
                this.gender = 'F';
            }else{
                this.name = "John Doe";
                this.gender = 'M';
            }
        }
    }
}
