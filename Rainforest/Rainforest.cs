using System;

namespace Rainforest
{
    class Program
    {
        static void Main(string[] args)
        {
            Company c1 = new Company("Rainforest");

            City t1 = new City("Austin");
            City t2 = new City("Chicago");
            City t3 = new City("Dallas");

            Warehouse w1 = new Warehouse("Warehouse_01");
        }
    }

    public class Company
    {
        public string companyName;

        public Company(string initialCompany)
        {
            this.companyName = initialCompany;
        }

        public String ToString(){
            string stringRepresentation = string.Format("{0}", this.companyName);
            return stringRepresentation;
        }
    }

    public class City
    {
        public string cityName;

        public City(string initialCity)
        {
            this.cityName = initialCity;
        }

        public String ToString(){
            string stringRepresentation = string.Format("{0}", this.cityName);
            return stringRepresentation;
        }
    }

    public class Warehouse
    {
        public string warehouseName;
    }

    public class Container
    {

    }

    public class Item
    {

    }
}
