using System;
using System.Collections.Generic;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "Borealis Green";

            Zero fx = new Zero();
            fx.MainColor = "Fuligin Black";

            Tesla modelS = new Tesla();
            modelS.MainColor = "Shitstain Brown";

            Ram ram2500 = new Ram();
            ram2500.MainColor = "Black Diamond";

            Cessna skylane182 = new Cessna();
            skylane182.MainColor = "White with Blus Stripe";


            List<Zero> electricVehicles = new List<Zero>() { fx, fxs };

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine();

            fx.Drive();
            fx.Turn("left");
            fx.Stop();
            Console.WriteLine();

            modelS.Drive();
            modelS.Turn("around");
            modelS.Stop();
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
