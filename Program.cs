using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP4
{
    class Program
    {
        static void Main()
        {
            Address address = new Address();

            address.Index = 123;
            address.Country = "Russia";
            address.City = "Moscow";
            address.Street = "Tverskaya";
            address.House = 10;
            address.Apartment = 15;

            Console.WriteLine("Address Information:");
            Console.WriteLine($"Index: {address.Index}");
            Console.WriteLine($"Country: {address.Country}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"Street: {address.Street}");
            Console.WriteLine($"House: {address.House}");
            Console.WriteLine($"Apartment: {address.Apartment}");

            Console.ReadKey();
        }
    }
}
