using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zrakoplov
{
    class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov();
            x380.setNaziv("Airbus");
            x380.setSnagaMotora(2000);
            x380.setDosegLeta(6000);

            Zrakoplov C162 = new Zrakoplov();
            C162.setNaziv("Cessna Skycatcher");
            C162.setSnagaMotora(75);
            C162.setDosegLeta(870);

            Zrakoplov PC_21 = new Zrakoplov();
            PC_21.setNaziv("Pilatus");
            PC_21.setSnagaMotora(1200);
            PC_21.setDosegLeta(1333);

            Console.WriteLine("Zrakoplov x380" + "\n"
            + "Naziv: " + x380.getNaziv() + "\n"
            + "Snaga motora: " + x380.getSnagaMotora() + " kW\n"
            + "Doseg leta: " + x380.getDosegLeta() + " km\n");

            Console.WriteLine("Zrakoplov C162" + "\n"
            + "Naziv: " + C162.getNaziv() + "\n"
            + "Snaga motora: " + C162.getSnagaMotora() + " kW\n"
            + "Doseg leta: " + C162.getDosegLeta() + " km\n");

            Console.WriteLine("Zrakoplov PC-21" + "\n"
            + "Naziv: " + PC_21.getNaziv() + "\n"
            + "Snaga motora: " + PC_21.getSnagaMotora() + " kW\n"
            + "Doseg leta: " + PC_21.getDosegLeta() + " km\n");

            Console.ReadKey();
        }
    }

    class Zrakoplov
    {
        String Naziv;
        double SnagaMotora;
        int DosegLeta;
        
        public void setNaziv(String Naziv)
        {
            this.Naziv = Naziv;
        }
        public void setSnagaMotora(double SnagaMotora)
        {
            this.SnagaMotora = SnagaMotora;
        }
        public void setDosegLeta(int DosegLeta)
        {
            this.DosegLeta = DosegLeta;
        }
        public String getNaziv()
        {
            return this.Naziv;
        }
        public double getSnagaMotora()
        {
            return this.SnagaMotora;
        }
        public int getDosegLeta()
        {
            return this.DosegLeta;
        }
    }
}
