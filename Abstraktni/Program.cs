using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktni
{

    // ta razred ni namenjen ustvarjanje objekte. Ampak za implementiranje ali implementiranje v nizjih nivojih ipd.
    abstract class GeometrijskoTelo
    {
        public abstract int Povrsina { set; }

        public abstract double IzracunajPovrsino();

        public abstract double IzracunajProstornino();

        private double _visina;

        public double Visina
        {
            get { return _visina; }
            set { _visina = value; }
        }

        public double IzracunajRazmerjeMedProstorninoInPovrsino()
        {
            return IzracunajProstornino() / IzracunajPovrsino();
        }


    }

    class Kocka : GeometrijskoTelo
    {
        private int a;
        private int _p;

        // ker je abstractna metoda moramo explicitno opisat override da deluje (nedvomno povemo
        public override int Povrsina
        {
            set { _p = value; }
        }

        public int A
        {
            set { a = value; }
            get { return a; }
        }

        public override double IzracunajPovrsino()
        {
            return 6 * A * A;
        }

        public override double IzracunajProstornino()
        {
            return A * A * A;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //GeometrijskoTelo gt = new GeometrijskoTelo();
            Kocka k1 = new Kocka();
            k1.A = 10;
            Console.WriteLine(k1.IzracunajPovrsino());
            k1.Visina = 10;
            Console.WriteLine(k1.IzracunajRazmerjeMedProstorninoInPovrsino());
        }
    }
}
