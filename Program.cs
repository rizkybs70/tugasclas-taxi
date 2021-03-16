using System;

namespace Tugas_Class_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            taxi data1 = new taxi();

            data1.DriverName = "Jono";
            data1.OnDuty = true;
            data1.NumPassenger = 10;

            data1.TaxiInfo();
            data1.PickUpPassenger();
            data1.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
