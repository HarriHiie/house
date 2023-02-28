using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum");

            Console.WriteLine(Majad.Singlehouse);

            int Maja = (int)Majad.Apartment;
            Console.WriteLine(Maja);

            var ma = (Majad)6;
            Console.WriteLine(ma);
        }
    }

    public enum Majad
    {
        Singlehouse,
        Coophouse,
        Townhouse,
        Multihome,
        Modularhome,
        Apartment = 6
        

    }
}
