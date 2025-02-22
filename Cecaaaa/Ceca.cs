using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Ceca
    {
        static Random random = new Random();

        private int kor; //no private is private lesz
        private int suly;
        string nev;
        string fajta;
        string szin;
        int rendetlensegSzint;
        bool ehes;
        string nem;
        int fogyasztas;

        public Ceca(int kor, int suly, string nev, string fajta, string szin, int rendetlensegSzint, string nem, int fogyasztas)
        {
            this.kor = kor;
            this.suly = suly;
            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;
            this.rendetlensegSzint = rendetlensegSzint;
            this.nem = nem;
            this.fogyasztas = fogyasztas;
            ehes = true;
        }

        public void Eves(double kajaSuly)
        {
            int esely = random.Next(101);
            ehes = false;
            if (esely <= 4)
            {
                szin = "zöld";
                suly -= (int)(suly * (esely / 100.0));
                rendetlensegSzint /= 2;
            }
            else
            {
                suly += (int)Math.Ceiling(fogyasztas * kajaSuly);
            }


        }
        public void Alvas()
        {
            rendetlensegSzint = 0;

            if (szin == "zöld")
            {
                szin = "Eredeti";
            }
        }

        public void Ebredes()
        {
            rendetlensegSzint = 100;
            ehes = true;
        }

        public void Jatek()
        {
            if (rendetlensegSzint == 0)
            {
                Alvas();
                return;
            }

            List<string> tevekenysegek = new List<string> { "ugral", "kapar", "kerget" };
            if (rendetlensegSzint > 50)
            {
                tevekenysegek.Add("bútorra mászik");
            }
            if (rendetlensegSzint > 80)
            {
                tevekenysegek.Add("romlott ételt eszik");
            }

            string kivalasztottTevekenyseg = tevekenysegek[random.Next(tevekenysegek.Count)];
            Console.WriteLine($"{nev} most {kivalasztottTevekenyseg}.");

            if (kivalasztottTevekenyseg == "romlott ételt eszik")
            {
                Eves(0.5);
            }

            rendetlensegSzint -= random.Next(5, 16);
            if (rendetlensegSzint < 0) rendetlensegSzint = 0;
        }

        private int MaxRendetlensegSzint()
        {
            int maxSzint = 100 - (kor * 2);
            if (szin == "narancssárga")
            {
                maxSzint += 10;
            }
            return Math.Max(maxSzint, 20);
        }

        public void HangotAd()
        {
            Console.WriteLine($"{nev} nyávog egyet.");
        }
    }
}