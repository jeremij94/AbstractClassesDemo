using System;
namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "something generic";
        public string Make { get; set; } = "something generic";
        public string Model { get; set; } = "something generic";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Appropriate driving mechanics");
        }
    }
}

