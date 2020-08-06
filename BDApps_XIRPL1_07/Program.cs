using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApps_XIRPL1_07
{
    class Program
    {

        static void quit()
        {
            System.Environment.Exit(0);
        }
        static int menu()
        {
            Console.Write("===== Menu =====\n1. Persegi\n2. Persegi Panjang\n3. Segitiga\n4. jajargenjang\n5. Trapesium\n6. layang-layang\n7. Belah ketupat\n\nPilih Menu Diatas : ");
            int pil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("================");
            return pil;
        }

        static void Main()
        {
            Bangun_datar bangundatar = new Bangun_datar();
            bangundatar.luas();
            bangundatar.keliling();

            int pill = menu();
            Console.WriteLine();

            if (pill == 1)
            {
                Persegi persegi = new Persegi();
                Console.Write("Masukan sisi : ");
                float input = float.Parse(Console.ReadLine());
                persegi.sisi = input;

                persegi.luas();
                persegi.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 2)
            {
                PersegiPanjang persegiPanjang = new PersegiPanjang();
                Console.Write("Masukan sisi panjang : ");
                float inputp = float.Parse(Console.ReadLine());
                Console.Write("Masukan sisi lebar : ");
                float inputl = float.Parse(Console.ReadLine());
                persegiPanjang.panjang = inputp;
                persegiPanjang.lebar = inputl;

                persegiPanjang.luas();
                persegiPanjang.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 3)
            {
                Segitiga segitiga = new Segitiga();
                Console.Write("Masukan panjang alas : ");
                float inputa = float.Parse(Console.ReadLine());
                Console.Write("Masukan tinggi segitiga : ");
                float inputt = float.Parse(Console.ReadLine());
                segitiga.alas = inputa;
                segitiga.tinggi = inputt;

                segitiga.luas();
                segitiga.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 4)
            {
                Jajargenjang jajargenjang = new Jajargenjang();
                Console.Write("Masukan sisi miring : ");
                float inputm = float.Parse(Console.ReadLine());
                Console.Write("Masukan sisi bawah : ");
                float inputb = float.Parse(Console.ReadLine());
                Console.Write("Masukan tinggi jajargenjang : ");
                float inputt = float.Parse(Console.ReadLine());

                jajargenjang.sisi_miring = inputm;
                jajargenjang.alas = inputb;
                jajargenjang.tinggi = inputt;

                jajargenjang.luas();
                jajargenjang.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 5)
            {
                Trapesium trapesium = new Trapesium();
                Console.Write("Masukan sisi miring : ");
                float inputm = float.Parse(Console.ReadLine());
                Console.Write("Masukan sisi atas : ");
                float inputa = float.Parse(Console.ReadLine());
                Console.Write("Masukan sisi bawah : ");
                float inputb = float.Parse(Console.ReadLine());
                Console.Write("Masukan tinggi trapesium : ");
                float inputt = float.Parse(Console.ReadLine());

                trapesium.sisi_miring = inputm;
                trapesium.sisi_atas = inputa;
                trapesium.sisi_bawah = inputb;
                trapesium.tinggi = inputt;

                trapesium.luas();
                trapesium.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else if (pill == 6)
            {
                LayangLayang layangLayang = new LayangLayang();
                Console.Write("Masukan sisi atas : ");
                float inputa = float.Parse(Console.ReadLine());
                Console.Write("Masukan sisi bawah : ");
                float inputb = float.Parse(Console.ReadLine());
                Console.Write("Masukan diagonal 1 : ");
                float inputd1 = float.Parse(Console.ReadLine());
                Console.Write("Masukan diagonal 2 : ");
                float inputd2 = float.Parse(Console.ReadLine());

                layangLayang.sisi_atas = inputa;
                layangLayang.sisi_bawah = inputb;
                layangLayang.d1 = inputd1;
                layangLayang.d2 = inputd2;

                layangLayang.luas();
                layangLayang.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }

            }
            else if (pill == 7)
            {
                Belahketupat belahketupat = new Belahketupat();
                Console.Write("Masukan sisi : ");
                float input = float.Parse(Console.ReadLine());
                Console.Write("Masukan diagonal 1 : ");
                float inputd1 = float.Parse(Console.ReadLine());
                Console.Write("Masukan diagonal 2 : ");
                float inputd2 = float.Parse(Console.ReadLine());

                belahketupat.sisi = input;
                belahketupat.d1 = inputd1;
                belahketupat.d2 = inputd2;

                belahketupat.luas();
                belahketupat.keliling();

                Console.Write("\n\nContinue? y/n:");
                string y = Console.ReadLine();
                if ((y == "y") | (y == "Y"))
                {
                    System.Console.Clear();
                    Main();
                }
                else
                {
                    quit();
                }
            }
            else
            {
                System.Console.Clear();
                Console.WriteLine("Menu Tidak tersedia");
                Main();
            }
        }
    }
}
