using System;

namespace GarysGarage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {
            Console.WriteLine($"You have filled your Ram to {this.FuelCapacity}");
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
