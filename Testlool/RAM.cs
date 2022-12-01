using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlool
{
    class RAM
    {
        string znacka;
        short velikost;
        int cena;
        public RAM()
        {

        }
        public RAM(string znacka, short velikost, int cena)
        {
            this.znacka = znacka;
            this.velikost = velikost;
            this.cena = cena;
        }
        public string Znacka
        {
            get
            {
                return znacka;
            }
        }
        public int Velikost
        {
            get
            {
                return velikost;
            }
        }
        public string RozjedeMinecraft(short velikost)
        {
            if (velikost >= 4)
            {
                return "Splňuje minimální požadavky pro Minecraft";
            }
            else
            {
                return "Nesplňuje minimální požadavky pro Minecraft";
            }
        }
        public string Cena(int cena)
        {
            if (cena >= 10000)
            {
                return "drahá";
            }
            else
            {
                return "levná";
            }
        }

        public override string ToString()
        {
            return "RAM značky " + Znacka + " má velikost " + Velikost + "GB a stojí " + cena + "Kč. " + RozjedeMinecraft(velikost) + " a je " + Cena(cena) + ".";
        }
}
}
