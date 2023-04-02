using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class Program
    {

        class Izracuni
        {
            public static int vrniKvadrat(int a)
            {
                return (a * a);
            }

            public static double vrniKvadrat(double a)
            {
                return (a * a);
            }
        }

        class Vektor
        {
            private int _x, _y;

            //konstruktor
            public Vektor(int x, int y)
            {
                _x = x;
                _y = y;
            }

            //
            public int X
            {
                get { return _x; }
                set { _x = value; }
            }

            public int Y
            {
                get { return _y; }
                set { _y = value; }
            }

            //operator
            public static Vektor operator +(Vektor v1, Vektor v2)
            {
                return new Vektor(v1.X + v2.X, v1.Y + v2.Y);
            }

            //operator odstevanje

            public static Vektor operator -(Vektor v1, Vektor v2)
            {
                return new Vektor (v1.X - v2.X, v1.Y - v2.Y);
            }

            public static Vektor operator ++(Vektor v1)
            {
                return new Vektor(v1.X++, v1.Y++);
            }

            public void Izpisi()
            {
                Console.WriteLine("V({0}, {1})", this.X, this.Y);
            }
        }  
        static void Main(string[] args)
        {

            Console.WriteLine("izpis");
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine(1.234 + 2.345);

            Console.WriteLine(Izracuni.vrniKvadrat(5));
            byte b = 100;
            Console.WriteLine(Izracuni.vrniKvadrat(b));
            Console.WriteLine(Izracuni.vrniKvadrat(5.1));
            Vektor vk1 = new Vektor(1, 3);
            Vektor vk2 = new Vektor(3, 5);
            Vektor vk3 = vk1 + vk2;  // je preobteženi operator v razredu Vektor
            vk3.Izpisi();  //'public void Izpisi' ki smo naredil
            Vektor vk4 = vk3 - vk2;
            vk4.Izpisi();
            vk4++;

        }
    }
}
