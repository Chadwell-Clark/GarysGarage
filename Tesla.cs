using System;

namespace GarysGarage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; } = 30;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla whines by you...Whiiiinnnne!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle turns {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Ai driven {MainColor} Tesla  gently rolls over the pedestrian and stops.");
        }
    }
}
