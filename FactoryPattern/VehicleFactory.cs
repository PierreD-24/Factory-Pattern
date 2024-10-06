using Microsoft.VisualBasic;

public static class VehicleFactory
{
    public static IVehicle MakeVehicle(int tires)
    {
        switch (tires)
        {
            case 2:
                return new Motorcycle();
            case 4:
                return new Car();
            default:
                return new Car();
        }
    }
}