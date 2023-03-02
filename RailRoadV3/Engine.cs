using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailRoadV3
{
    class Engine
    {
        private string make;
        private string model;
        private string engine_no;
        private int horsePower;
        private int tractive;

        public Engine(string make, string model, string engine_no, int horsePower, int tractive)
        {
            this.make = make;
            this.model = model;
            this.engine_no = engine_no;
            this.horsePower = horsePower;
            this.tractive = tractive;
        }

        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string Engine_no
        {
            get
            {
                return engine_no;
            }

            set
            {
                engine_no = value;
            }
        }

        public int HorsePower
        {
            get
            {
                return horsePower;
            }

            set
            {
                horsePower = value;
            }
        }

        public int Tractive
        {
            get
            {
                return tractive;
            }

            set
            {
                tractive = value;
            }
        }
    }
}
