using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siedze
{
    class Samochod
    {
        public int moc;
        public int pojemnoscSilnika;
        public bool swiatlaWlaczone;
        public bool silnikWlaczony;

        public void WlaczSwiatla()
        {
            if (swiatlaWlaczone == false)
            {
                swiatlaWlaczone = true;
            }
        }
        public Samochod() { }
    }

    class Pojazd : Samochod
    {
        public string marka;
        public string model;

        public void WlaczSilnik()
        {
            if (silnikWlaczony == false)
            {
                silnikWlaczony = true;
            }
        }
        public Pojazd()
        {
            moc = 0;
            pojemnoscSilnika = 0;
            swiatlaWlaczone = false;
            silnikWlaczony = false;
            marka = "brak";
            model = "brak";
        }
        public Pojazd(int Moc, int PojemnoscSilnika, bool SwiatlaWlaczone, bool SilnikWlaczony, string Marka, string Model)
        {
            moc = Moc;
            pojemnoscSilnika = PojemnoscSilnika;
            swiatlaWlaczone = SwiatlaWlaczone;
            silnikWlaczony = SilnikWlaczony;
            marka = Marka;
            model = Model;
        }
    }
}