using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
            
        }

        public int TrunkSize { get; set; }

        public int Wheels { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }

        public string Drive()
        {
        return ("car goes vroom");
        }

        public string Name { get; set; }
        public int Value { get; set; }
    }
}
