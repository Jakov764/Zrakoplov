using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovKlaseIObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov();

            x380.setNaziv("Airbus");
            x380.setdosegLeta(6000);
            x380.setsnagaMotora(2000);

            Console.WriteLine("\nNaziv: " + x380.getNaziv() + "\nSnaga: " + x380.getsnagaMotora() 
                + "kW" + "\nDoseg leta: " + x380.getdosegLeta() + "km");

            Zrakoplov PU123RO = new Zrakoplov("Cessna", 350, 125);

            Console.WriteLine(PU123RO.ToString());

            Zrakoplov x328 = new Zrakoplov("MeanMachine", 5000);

            Console.WriteLine("Upisi koji je doseg leta zrakoplova MeanMachine: ");

            x328.setdosegLeta(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(x328.ToString());

            Console.ReadKey();
        }
    }
}
