using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siedze
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Pojazd woz = new Pojazd(20, 20, false, false, "opel", "corsa");
            woz.WlaczSilnik();
            Console.WriteLine(woz.moc + " " + woz.pojemnoscSilnika + " " + woz.swiatlaWlaczone + " " + woz.silnikWlaczony + " " + woz.marka + " " + woz.model);

            Pojazd[] pojazdy = new Pojazd[2];
            pojazdy[0] = new Pojazd(1000, 7000, false, false, "Mercedes-Benz", "S65");
            pojazdy[1] = new Pojazd(20, 50, true, false, "Volkswagen", "Golf");

            pojazdy[0].WlaczSwiatla();

            for (int i = 0; i < pojazdy.Length; i++)
            {
                Console.WriteLine(pojazdy[i].moc + " " + pojazdy[i].pojemnoscSilnika + " " + pojazdy[i].swiatlaWlaczone + " " + pojazdy[i].silnikWlaczony + " " + pojazdy[i].marka + " " + pojazdy[i].model);
            }

            Console.ReadKey();
        }
    }
}
