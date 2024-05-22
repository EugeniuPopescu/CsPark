using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEma
{
    internal class Moto : IDrivable
    {
        private string vehiclePlate;
        // costante
        public const string MOTOTYPE = nameof(MOTOTYPE);


        public Moto(string plate) 
        {
            this.vehiclePlate = plate;
        }

        public string GetPlate()
        {
            return vehiclePlate;
        }

        public string GetVehicleType()
        {
            return MOTOTYPE;
        }
    }
}
