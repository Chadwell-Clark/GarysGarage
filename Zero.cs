using System;

namespace GarysGarage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"YOur Zero is now charged to{this.BatteryKWh}Khw");

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
