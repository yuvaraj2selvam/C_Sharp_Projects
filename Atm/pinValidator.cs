using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    internal class pinValidator
    {
        public static bool check( string pin)
        {
            if(pin == null || pin.Length!=6)
                return false;

            return true;
        }
    }
}
