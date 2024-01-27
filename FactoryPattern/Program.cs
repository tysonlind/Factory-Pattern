using System.Security.Cryptography.X509Certificates;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            IVehicle newMotorcycle = VehicleFactory.GetVehicle(2, false);
            IVehicle newTruck = VehicleFactory.GetVehicle(4, true);
            IVehicle newCar = VehicleFactory.GetVehicle(4, false);

            if (newMotorcycle is Motorcycle motorcycle)
            {
                Console.WriteLine($"{motorcycle.Type}");
            }
            
        }
    }
}
