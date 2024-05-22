using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEma
{
    class Vehicle
    {
        // protected -> perche i figli ereditano la targa
        protected string vehiclePlate { get; set; }
        // esempio con private, si poteva mettere protected, ma passo al figlio attraverso il costruttore
        private string vehicleType { get; set; }

        // costruttore
        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        // metodo per la avere la targa
        public string GetPlate()
        {
            return vehiclePlate;
        }

        // metodo per la avere il tipo di veicolo
        public string GetVehicleType()
        {
            return vehicleType;
        }
    }
}
