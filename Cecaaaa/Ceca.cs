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
        int rendetlenségSzint;
        bool ehes;
        string nem;
        int fogyasztas;

        public Ceca(int kor, int suly, string nev, string fajta, string szin, int rendetlenségSzint, string nem, int fogyasztas)
        {
            this.kor = kor;
            this.suly = suly;
            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;
            this.rendetlenségSzint = rendetlenségSzint;
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
                rendetlenségSzint /= 2;
            }
            else
            {
                suly += (int)Math.Ceiling(fogyasztas * kajaSuly);
            }


        }
        public void Alvas()
        {
            rendetlenségSzint = 0;

            if (szin == "zöld")
            {
                szin = "Eredeti";
            }
        }

        public void Ebredes()
        {
            rendetlenségSzint = 100;
            ehes = true;
        }

        public void Jatek()
        {

            if (rendetlenségSzint == 0)
            {
                Alvas();
            }
            else
            {

            }
        }
    }
}