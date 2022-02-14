using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Address someAddress = new Address();

            someAddress.Index = 04210;
            someAddress.Country = "Ukraine";
            someAddress.City = "Kyiv";
            someAddress.Street = "Vyshgorodskaya";
            someAddress.House = 6;
            someAddress.Apartment = 67;

            Console.WriteLine($"Index: {someAddress.Index}; Country: {someAddress.Country}; City: {someAddress.City}; Street: {someAddress.Street}; House: {someAddress.House}; Apartment: {someAddress.Apartment}");

            Console.ReadKey();



        }
    }
}
