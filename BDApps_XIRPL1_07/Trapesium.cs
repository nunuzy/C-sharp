using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApps_XIRPL1_07
{
    class Trapesium : Bangun_datar
    {
        public float sisi_miring;
        public float sisi_atas;
        public float sisi_bawah;
        public float tinggi;

        public override float luas()
        {
            float luas = ((sisi_atas + sisi_bawah) * tinggi) / 2;
            Console.WriteLine("Luas Teapesium : " + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = (sisi_miring * 2) + sisi_atas + sisi_bawah;
            Console.WriteLine("Keliling Trapesium " + keliling);
            return keliling;
        }
    }
}
