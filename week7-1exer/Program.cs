using System;

namespace week7_1exer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Bobby", "Hill", GenderType.MALE);
            Console.WriteLine(person.FirstName);
        }
    }

    public enum DaysOfWeek{
        SUNDAY, MONDAY, TUESDAY,WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
    }

    public enum GenderType{
        MALE, FEMALE, OTHER
    }

    public class Address
    {
        public string street1 = "168th street";
        public string street2;
        public string city = "South Holland";
        public string state = "IL";
        public int zip = 60473;
    }

    public class driversLicense
    {
        public Person info;
        public Address mailingAddress;
        public string licenseType = "D";
    }

    public struct Person
    {
        public string FirstName {get; set;}
        public string LastName;
        public GenderType gender;

        public Person(string initialfirstname, string initiallastname, GenderType initialgender){
            this.FirstName = initialfirstname;
            this.LastName = initiallastname;
            this.gender = initialgender;
        }

        public string getFullName(){
            return FirstName+ " "+ LastName;
        }
    }
}
