using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailRoadV3
{
    class Train
    {
        private string trainNumber;
        private List<Engine> engines;
        private List<BaseCar> cars;

        public Train(string trainNumber, List<Engine> engines, List<BaseCar> cars)
        {
            this.trainNumber = trainNumber;
            this.engines = engines;
            this.cars = cars;
        }

        public string TrainNumber
        {
            get
            {
                return trainNumber;
            }

        }

        internal List<Engine> Engines
        {
            get
            {
                return engines;
            }

            set
            {
                engines = value;
            }
        }

        internal List<BaseCar> Cars
        {
            get
            {
                return cars;
            }

            set
            {
                cars = value;
            }
        }
    }
}
