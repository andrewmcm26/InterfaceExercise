using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
            Wheels = 4;
            Color = "Grey";
            Doors = 4;
            Name = "Dodge";
            Value = 999;
        }

        public int CargoHoldSize { get; set; }

        public int Wheels { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }

        public string Drive()
        {
            return ("SUV goes rrrrm");
        }

        public string Name { get; set; }
        public int Value { get; set; }

    }
}
