using System;

namespace GarysGarage
{
    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; } = 46;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;

        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} zero zips by... Zipppppp!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero turns {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The vehicle gently rolls to a stop. Then falls over");
        }
    }
}
