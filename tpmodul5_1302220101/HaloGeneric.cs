using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302220101
{
    internal class HaloGeneric
    {
        public static void SapaUser<T>(T x)
        {
            Console.WriteLine("Halo user " + x);
        }
    }
}
