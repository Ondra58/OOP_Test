using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testlool
{
    class Procesor
    {
        string znacka;
        int rychlost;
        int pocetjader;
        public Procesor()
        {

        }
        public Procesor(string znacka, int rychlost, int pocetjader)
        {
            this.znacka = znacka;
            this.rychlost = rychlost;
            this.pocetjader = pocetjader;
        }
        public string Znacka
        {
            get
            {
                return znacka;
            }
        }
        public int Rychlost
        {
            get{
                return rychlost;
            }
        }
        public string Vykon(int rychlost)
        {
            if(rychlost >= 3)
            {
                return "rychlý";
            }
            else
            {
                return "pomalý";
            }
        }
        public string Cena(int pocetjader)
        {
            if (pocetjader >= 8)
            {
                return "drahý";
            }
            else
            {
                return "levný";
            }
        }
        public string PocetJader(int pocetjader)
        {
            if (pocetjader == 1)
            {
                return pocetjader + " jádro";
            }
            else if(pocetjader == 2 || pocetjader == 3 || pocetjader == 4)
            {
                return pocetjader + " jádra";
            }
            else
            {
                return pocetjader + " jader";
            }
        }

        public override string ToString()
        {
            return "Procesor značky " + Znacka + " má rychlost " + Rychlost + "GHz a má " + PocetJader(pocetjader) + ". Tudíž je " + Vykon(rychlost) + " a " + Cena(pocetjader)+ ".";
        }
    }
}
