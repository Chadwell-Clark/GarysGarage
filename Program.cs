using System;
using System.Collections.Generic;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
              };
            Console.Clear();
            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev}'s is {ev.CurrentChargePercentage} % charged");
            }
            Console.WriteLine();
            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
                Console.WriteLine($"Recharging {ev}'s battery banks.");
            }
            Console.WriteLine();
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev}'s is now {ev.CurrentChargePercentage}% charged");
            }

            /***********************************************/
            Console.WriteLine();

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv}'s tank is{gv.CurrentTankPercentage}% full.");
            }
            Console.WriteLine();
            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
                Console.WriteLine($"Refueling {gv}'s tank.");
            }
            Console.WriteLine();
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv}'s tank is now {gv.CurrentTankPercentage}% full.");
            }

            Zero myFXS = new Zero();
            myFXS.MainColor = "Borealis Green";

            Zero superfx = new Zero();
            superfx.MainColor = "Fuligin Black";

            Tesla modelT = new Tesla();
            modelT.MainColor = "Shitstain Brown";

            Ram ram2500 = new Ram();
            ram2500.MainColor = "Black Diamond";

            Cessna skylane182 = new Cessna();
            skylane182.MainColor = "White with Blus Stripe";


            List<Zero> electricVehicles2 = new List<Zero>() { superfx, myFXS };

            myFXS.Drive();
            myFXS.Turn("right");
            myFXS.Stop();
            Console.WriteLine();

            superfx.Drive();
            superfx.Turn("left");
            superfx.Stop();
            Console.WriteLine();

            modelT.Drive();
            modelT.Turn("around");
            modelT.Stop();
            Console.WriteLine();

            ram2500.Drive();
            ram2500.Turn("any way it wants");
            ram2500.Stop();
            Console.WriteLine();

            skylane182.Drive();
            skylane182.Turn("loops");
            skylane182.Stop();
            Console.WriteLine();
        }
    }
}

// namespace GarysGarage
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Zero fxs = new Zero();
//             fxs.MainColor = "Borealis Green";

//             Zero fx = new Zero();
//             fx.MainColor = "Fuligin Black";

//             Tesla modelS = new Tesla();
//             modelS.MainColor = "Shitstain Brown";

//             Ram ram2500 = new Ram();
//             ram2500.MainColor = "Black Diamond";

//             Cessna skylane182 = new Cessna();
//             skylane182.MainColor = "White with Blus Stripe";


//             List<Zero> electricVehicles = new List<Zero>() { fx, fxs };

//             fxs.Drive();
//             fxs.Turn("right");
//             fxs.Stop();
//             Console.WriteLine();

//             fx.Drive();
//             fx.Turn("left");
//             fx.Stop();
//             Console.WriteLine();

//             modelS.Drive();
//             modelS.Turn("around");
//             modelS.Stop();
//             Console.WriteLine();

//             ram2500.Drive();
//             ram2500.Turn("any way it wants");
//             ram2500.Stop();
//             Console.WriteLine();

//             skylane182.Drive();
//             skylane182.Turn("loops");
//             skylane182.Stop();
//             Console.WriteLine();
//         }
//     }
// }
