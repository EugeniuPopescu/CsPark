using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEma
{
    internal class Car : IDrivable
    {
        private string vehiclePlate;

        public const string CARTYPE =  nameof(CARTYPE); // "CarType"

        // targa passata dal padre 
        public Car(string plate) 
        {
            this.vehiclePlate = plate;
        }

        public string GetPlate()
        {
            return vehiclePlate;
        }

        public string GetVehicleType()
        {
            return CARTYPE;
        }
    }
}
