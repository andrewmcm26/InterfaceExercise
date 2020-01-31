using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
           

        }

        public int BedSize { get; set; }

        public int Wheels { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }

        public string Drive()
        {
            return ("Truck goes chugalug");
        }

        public string Name { get; set; }
        public int Value { get; set; }
    }

}
