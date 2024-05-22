using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEma
{
    class Park
    {
        private List<IDrivable> vehiclesList = new List<IDrivable>();
        private int _carTax;
        private int _motoTax;
        private int _maxParkSpace;

        // costruttore
        public Park(int carTax, int motoTax, int maxParkSpace)
        {
            _carTax = carTax;   
            _motoTax = motoTax;
            _maxParkSpace = maxParkSpace;
        }

        // metodo che mi restituisce i posti liberi
        public int GetAvailableParkSpace()
        {
            int res = _maxParkSpace - vehiclesList.Count;

            if (res > 0)
            {
                res = _maxParkSpace - vehiclesList.Count;
            }
            else
            {
                res = 0;
            }

            return res;
        }


        // metodo che mi ritorna un booleano se non ci sono più posti disponibili 
        // privato perchè lo implemento solo nella classe
        private bool IsFull()
        {
            return vehiclesList.Count >= _maxParkSpace;
        }

        // method toAddVehicle, di tipo bool
        public bool ToAddVehicle(IDrivable vehicle)
        {
            // se IsFull è vero non si può aggiungere il veicolo
            if (IsFull())
            {
                return false;
            }


            // ciclo tutte le targhe dei veicoli, per controllare se il veicolo è già presente
            foreach (var vehicleI in vehiclesList)
            {
                if (vehicleI.GetPlate() == vehicle.GetPlate())
                {
                    //ritorna falso perche il veicolo è già presente
                    return false;
                }
            }

            // prendo la mia lista di veicoli e la riempio 
            vehiclesList.Add(vehicle);
            return true;
        }

        // method toRemoveVehicle, per rimuovere il veicolo attraverso la targa
        public bool ToRemoveVehicle(string vehiclePlate)
        {
            // Se gli passo una stringa nulla o vuota ritorna false
            if(String.IsNullOrEmpty(vehiclePlate))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < vehiclesList.Count; i++)
                {
                    if (vehiclesList[i].GetPlate() == vehiclePlate)
                    {
                        vehiclesList.Remove(vehiclesList[i]);

                        return true;
                    }
               
                }
                return false;
            }


        }

        // method to know the amounth value 
        public int GetAmountPark()
        {
            int totAmounth = 0;
            
            foreach (var vehicle in vehiclesList)
            {
                if (vehicle.GetVehicleType().Equals(Car.CARTYPE))
                {
                    totAmounth += _carTax;
                    continue;
                }
                if (vehicle.GetVehicleType().Equals(Moto.MOTOTYPE))
                {
                    totAmounth += _motoTax;                  
                }
            }

            return totAmounth;
        }
    }
}
