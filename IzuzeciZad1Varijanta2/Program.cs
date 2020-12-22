using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzuzeciZad1
{
    class Program
    {
        //Prikazati metod za testiranje za deljenje sa nulom i prikaz greške. Bez rukovanja 
        //izuzetkom, ovaj program će biti prekinut sa javljanjem greške koju daje izuzetak
        //DivideByZeroException

        public static double Deljenje(double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }

        static void Main(string[] args)
        {
            try
            {
                double rezultat;
                Console.Write("Unesite a: ");
                double a;
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Unesite b: ");
                double b;
                b = Convert.ToDouble(Console.ReadLine());



                rezultat = Deljenje(a, b);
                Console.WriteLine("Rezultat deljenja {0} sa {1} je: {2}", a, b, rezultat);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nemoguce je deljenje sa nulom.");
            }
            Console.ReadLine();
        }
    }
}
