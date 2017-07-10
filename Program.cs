using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Tesla Model S");
            Showroom.Add("Toyota LandCruiser Intl");
            Showroom.Add("Mercedes 240D");
            Showroom.Add("Subaru Outback");

            // Console.WriteLine(Showroom.Count);

            Showroom.Add("Subaru Outback");

            // foreach(string car in Showroom){
            //     Console.WriteLine(car);
            // }

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Volvo 240");
            UsedLot.Add("Toyota Hilux");

            Showroom.UnionWith(UsedLot);
            // foreach(string car in Showroom){
            //     Console.WriteLine(car);
            // }

            Showroom.Remove("Subaru Outback");
            // foreach(string car in Showroom){
            //     Console.WriteLine(car);
            // }

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("VW Bus");
            Junkyard.Add("1968 Ford Mustang");
            Junkyard.Add("Volvo 240");
            Junkyard.Add("Toyota Hilux");

            Showroom.IntersectWith(Junkyard);
            // foreach(string car in Showroom){
            //     Console.WriteLine(car);
            // }

            Showroom.UnionWith(Junkyard);
            foreach(string car in Showroom){
                Console.WriteLine(car);
            }
        }
    }
}
