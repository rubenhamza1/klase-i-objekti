using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba2
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] niz = new int[5];
            int redniBroj = 1;
            Console.WriteLine("Vjezba 2 - Klase i objekti\n");
            Console.WriteLine("Upisi 5 brojeva: ");
            for (int brojac = 0; brojac < niz.Length; brojac++)
            {
                Console.WriteLine(redniBroj + ". broj: ");
                niz[brojac] = Convert.ToInt32(Console.ReadLine());
                redniBroj++;
            }
            KlasaC objekt = new KlasaC();
            Console.WriteLine("Zbroj clanova niza je: " + objekt.Zbroj(niz));
            Console.WriteLine("Prosjek clanova niza je: " + objekt.Prosjek(niz));
            Console.ReadKey();

        }
    }
    class KlasaC
    { 
        public int Zbroj(int[] niz)
        {
            int zbroj = 0;
            for(int brojac = 0; brojac < niz.Length; brojac++)
            {
                zbroj += niz[brojac];
            }
            return zbroj;
        }
        public double Prosjek(int[] niz)
        {
            double zbroj = Zbroj(niz);
            double prosjek = zbroj / niz.Length;

            return prosjek;
        }
    }
}
