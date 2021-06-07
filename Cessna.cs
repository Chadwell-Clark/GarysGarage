using System;

namespace GarysGarage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {
            Console.WriteLine($"You have filled your Cessna to {this.FuelCapacity}");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies over you...ZOOOOOOM!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna turns {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna  bounces a few times and then the taildragger slowly comes to a stop on the grass strip runway.");
        }
    }
}

