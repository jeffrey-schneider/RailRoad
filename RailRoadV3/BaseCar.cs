using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailRoadV3
{
    class BaseCar
    {
     
            protected string carType;
            protected string carNumber;
            protected string departure;
            protected string destination;
            protected int tare;
            protected int capacity;
            protected int cargoWt;
            protected string cargo;
            private string hazardClass;

            public string Departure
            {
                get
                {
                    return departure;
                }

                set
                {
                    departure = value;
                }
            }

            public string Destination
            {
                get
                {
                    return destination;
                }

                set
                {
                    destination = value;
                }
            }

            public int Tare
            {
                get
                {
                    return tare;
                }

                set
                {
                    tare = value;
                }
            }

            public int Capacity
            {
                get
                {
                    return capacity;
                }

                set
                {
                    capacity = value;
                }
            }

            public int CargoWt
            {
                get
                {
                    return cargoWt;
                }

                set
                {
                    cargoWt = value;
                }
            }

            public string Cargo
            {
                get
                {
                    return cargo;
                }

                set
                {
                    cargo = value;
                }
            }

            public string CarType
            {
                get
                {
                    return carType;
                }


            }

            public string CarNumber
            {
                get
                {
                    return carNumber;
                }


            }

            public BaseCar(string carType, string carNumber, string departure, string destination, int tare, int capacity, int cargoWt, string cargo, string hazardClass)
            {
                this.carType = carType;
                this.carNumber = carNumber;
                this.Departure = departure;
                this.Destination = destination;
                this.Tare = tare;
                this.Capacity = capacity;
                this.CargoWt = cargoWt;
                this.Cargo = cargo;
                this.hazardClass = hazardClass;
            }

            public int TotalWeight { get { return Tare + CargoWt; } }

            public override string ToString()
            {
                return carType + " " +
               carNumber + " " +
               Departure + " " +
               Destination + " " +
               Tare + " " +
               Capacity + " " +
               CargoWt + " " +
               Cargo + " " +
               hazardClass;
            }

        }
    }
