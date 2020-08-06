using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApps_XIRPL1_07
{
    class PersegiPanjang : Bangun_datar
    {
        public float panjang;
        public float lebar;

        public override float luas()
        {
            float luas = panjang * lebar;
            Console.WriteLine("Luas Persegi panjang : " + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = 2 * panjang + 2 * lebar;
            Console.WriteLine("Keliling Persegi panjang :" + keliling);
            return keliling;
        }

    }
}
