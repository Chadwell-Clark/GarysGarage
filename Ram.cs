using System;

namespace GarysGarage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; } = 63;
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram varooms by you...VROOOMM VROOOM!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The badass {MainColor} Ram turns {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram screeches to a stop.");
        }
    }


}
