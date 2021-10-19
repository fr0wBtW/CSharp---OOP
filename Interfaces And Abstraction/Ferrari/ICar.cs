using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
    public interface ICar
    {
        string Model { get; }
        string DriverName { get; set; }


        string PushBrakes();
        string PushGasPedal();
    }
}
