using System;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Address address = new Address();

            address.Index = "0033344";
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Velika Vasilkivska";
            address.House = 23;
            address.Apartment = 101;

            Console.WriteLine($"{address.Index}, {address.Country} {address.City} city");
            Console.WriteLine($"{address.Street} street House {address.House} Apartment {address.Apartment}");
        }
    }
}