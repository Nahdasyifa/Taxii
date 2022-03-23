using System;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek taxi
            Taxi taxi = new Taxi();

            // penentuan nilai properties
            taxi.DriverName = "Sulis";
            taxi.OnDuty = true;
            taxi.NumPassenger = 25;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DroppOffPassenger();

            Console.ReadKey();
        }
    }
}