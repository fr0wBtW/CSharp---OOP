using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        public Ferrari(string driverName)
        {
            this.DriverName = driverName;
        }

        public string Model => "488-Spider";

        public string DriverName { get; set; }

        public string PushBrakes()
        {
            return "Brakes";
        }

        public string PushGasPedal()
        {
            return "Speed";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.PushBrakes()}/{this.PushGasPedal()}/{this.DriverName}";
        }
    }
}
