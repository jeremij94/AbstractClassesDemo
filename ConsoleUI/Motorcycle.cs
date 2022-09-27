using System;
namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Quick and powerful out of the gate and sharp turns and long cruises");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Drive is tailored to motorcycle performance");
        }
    }
}

