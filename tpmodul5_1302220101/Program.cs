using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302220101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nama = "Yoga Fikri";
            HaloGeneric.SapaUser(nama);

            DataGeneric<int> data = new DataGeneric<int>(1302220101);
            data.PrintData();
        }
    }

}
