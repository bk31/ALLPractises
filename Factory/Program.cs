namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public interface IVehicle
    {
        string GetVehicleType(string vehicleType);
        int NumberOfWheels();
    }
    public class Car : IVehicle
    {
        private readonly int wheels;

        public Car()
        {
            this.wheels = 4;
        }

        public string GetVehicleType(string vehicleType)
        {
            if (vehicleType == "Car")
            {
                Console.WriteLine("Car");
            }
            return vehicleType;
        }

        public int NumberOfWheels()
        {
            return this.wheels;
        }
    }
    public class AirPlane : IVehicle
    {
        private readonly  int wheels;
        public AirPlane()
        {
            this.wheels = 3;
        }
        public string GetVehicleType(string vehicleType)
        {
            if(vehicleType == "Airplane")
            {
                Console.Write("AirPlane");
            }
            return vehicleType;
        }

        public int NumberOfWheels()
        {
            return wheels;
        }
    }
    public class Factory
    {
        
        public static IVehicle GetVehicle(string type)
        {
            IVehicle vehicle = null;
            if(type.ToLower().Equals("car"))
            {
                vehicle= new Car();
            }
            else if(type.ToLower().Equals("Airoplane"))
            {
                vehicle= new AirPlane();
            }
            return vehicle;
        }
    }
}
