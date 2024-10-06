﻿namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have?");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int tires))
            {
                IVehicle vehicle = VehicleFactory.MakeVehicle(tires); 
                vehicle.Drive(); 
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
