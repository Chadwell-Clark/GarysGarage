namespace GarysGarage
{
    public interface IElectricVehicle
    {
        double BatteryKWh { get; set; }

        int CurrentChargePercentage { get; set; }
        void ChargeBattery();
    }
}