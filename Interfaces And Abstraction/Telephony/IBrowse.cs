using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public interface IBrowse
    {
        List<string> Websites { get; set; }

        string Browse();
    }
}
