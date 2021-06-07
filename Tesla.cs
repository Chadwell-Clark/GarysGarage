using System;

namespace GarysGarage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"Your Tesla is now charged to {this.BatteryKWh}KHw.");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla whines by you...Whiiiinnnne!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle turns {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Ai driven {MainColor} Tesla  gently rolls over the pedestrian and stops.");
        }
    }
}
