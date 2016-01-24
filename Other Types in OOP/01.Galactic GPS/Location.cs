using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Galactic_GPS
{
    struct Location
    {
        private double latitude;
        private double longitude;
        public Location(double latitude,double longitude,Planet planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }
        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value < -90.0 || value > 90.0)
                {
                    throw new ArgumentOutOfRangeException("Latitude must be in range -90.0 ... 90.0");
                }
                this.latitude = value;
            }
        }
        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value < -180.0 || value > 180.0)
                {
                    throw new ArgumentOutOfRangeException("Longitude must be in range -180.0 ... 180.0");
                }
                this.longitude = value;
            }
        }
        public Planet Planet { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude,this.Longitude,this.Planet);
        }
    }
}
