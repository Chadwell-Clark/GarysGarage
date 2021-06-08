using System;

namespace GarysGarage
{
    public class Cessna : Vehicle, IFlyingVehicle, IGasVehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; } = 93;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public void Fly()
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

