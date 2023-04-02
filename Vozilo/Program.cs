using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozilo
{
    // hierarhijo delamo od splošno do specifični kodo
    class Vozilo
    {
        public string znamka;
        public string model;
        public int letoIzdelave;
        private int _hitrost;

        public int Hitrost
        {
            get{ return _hitrost; }
        }

        public void Pospesi(int kmu)
        {
            _hitrost += kmu;
        }

        public void Upocasni(int kmu)
        {
            _hitrost -= kmu;
        }
        public void Izpisi()
        {
            Console.WriteLine("Trenutna hitrost je {0}", this.Hitrost);
        }

        public void Nakazi (bool zavijLevo)
        {
            if (zavijLevo)
                Console.WriteLine("Zavijamo levo");
            else
                Console.WriteLine("Zavijamo desno");
        }

    }
    //pri podrejenih razredih neki specifično definiramo ter podedujemo od glavnega
    class MotornoVozilo : Vozilo
    {

        //smo dodali spicifično kodo za MotornoVozilo
        private float _seGoriva;
        private float _velikostTanka;

        public float SeGoriva
        {
            get{ return _seGoriva; }
        }

        public float VelikostTanka
        {
            get{ return _seGoriva; }
            set{ _velikostTanka = value; }
        }

        public float Natankaj()
        {
            float potrebnoGoriva = _velikostTanka - _seGoriva;
            _seGoriva = _velikostTanka;
            return potrebnoGoriva;
        }

    }
    class Kolo : Vozilo
    {

        public void Pozvoni()
        {
            Console.WriteLine("Driin");
        }
        
        //s to kodo smo prekrili glavno kodo vozila in se uporabil Nakazi samo specificno za Kolo
        public void Nakazi(bool vLevo)
        {
            //z 'base' besedo lahko prikličemo določeno metodo iz nadrejenega razreda
            base.Nakazi(vLevo);
            //nato nadaljuje z 'if' kodo
            if (vLevo)
                Console.WriteLine("Leva roka");
            else
                Console.WriteLine("Desna roka");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Vozilo avto = new Vozilo();
            avto.Izpisi();
            avto.Pospesi(30);
            avto.Izpisi();
            avto.Pospesi(20);
            avto.Upocasni(10);
            avto.Upocasni(30);
            avto.Izpisi();
            //dedovanje za avto
            MotornoVozilo mojAvto = new MotornoVozilo();
            mojAvto.Izpisi();
            mojAvto.Pospesi(30);
            mojAvto.Izpisi();
            mojAvto.Pospesi(20);
            mojAvto.Upocasni(10);
            mojAvto.Upocasni(30);
            mojAvto.Izpisi();
            //deodvanje za kolo
            Kolo mojKolo = new Kolo();
            mojKolo.Izpisi();
            mojKolo.Pospesi(30);
            mojKolo.Izpisi();
            mojKolo.Pospesi(20);
            mojKolo.Upocasni(10);
            mojKolo.Upocasni(30);
            mojKolo.Izpisi();
            mojKolo.Pozvoni();
            mojKolo.Nakazi(true);


        }
    }
}
