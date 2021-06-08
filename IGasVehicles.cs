namespace GarysGarage
{
    public interface IGasVehicle
    {
        void RefuelTank();

        int CurrentTankPercentage { get; set; }
    }
}