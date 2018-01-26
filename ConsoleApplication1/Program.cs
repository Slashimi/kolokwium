using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
        abstract class Sportowiec
    {
        protected string imie;
        protected char klub;
        
        public abstract string Zawody(int rekord);
    }

    class Biegacz : Sportowiec
    {
        private int rekord;
        public string zawodyo;
        
        public Biegacz(string imie, char klub, int rekord)
        {
            this.imie = imie;
            this.klub = klub;
            this.rekord = rekord;
        }
        public override string Zawody(int zawody)
        {
            for (int i = 0;i<zawody ; i++)
            {
                //zawodyo[i] = 'a'; 
            }
                return zawodyo;

        }
        public override string ToString()
        {
            return (imie + klub.ToString() + rekord.ToString());
        }
    }
    interface IOlimpiada
    {
        int Miejsce(string miejsce);
        bool Medal();
    }
    class Zawodnik
    {
        public override string ToString()
        {
            return czas.ToString();
        }
        private int czas;

        public int Miejsce(string miejsce)
        {
            return miejsce.Length;
        }
        public bool Medal()
        {
            if (czas / 2 == 0) return true;

            else return false;
        }
    }
    class Zawody
    {
        private int iloscZawodnikow;
        public Zawody(int iloscZawodnikow)
        {
            this.iloscZawodnikow = iloscZawodnikow;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Sportowiec> sport = new List<Sportowiec>();

            Biegacz osoba1 = new Biegacz("Piotrek", 'H', 15);
            Biegacz osoba2 = new Biegacz("Pawel", 'W', 14);
            Biegacz osoba3 = new Biegacz("Anna", 'D', 19);
            Biegacz osoba4 = new Biegacz("Seba", 'P', 15);
            sport.Add(osoba1);
            sport.Add(osoba2);
            sport.Add(osoba3);
            sport.Add(osoba4);
            foreach(Biegacz x in sport)
            {
                Console.WriteLine(x);
            }

            /////4
            foreach (Biegacz x in sport)
            {
                Console.WriteLine(x);
            }
            sport.Reverse();
            foreach (Biegacz x in sport)
            {
                Console.WriteLine(x);
            }

            //Console.WriteLine.Zawodnik.Miejsce("Kdsafaf");


            /////////////////////////////6
            int intTemp = Convert.ToInt32(Console.ReadLine());
            Zawodnik zawodnik1 = new Zawodnik();
            /*

            try
            {
                int Temp = zawodnik1.ToString();
            }
            catch (InvalidCastException e)
            {
            }

             * Console.ReadKey(); */

            Zawody zaw1 = new Zawody(7);
            Zawody zaw2 = new Zawody(2);
            Zawody zaw3 = new Zawody(4);
            Zawody zaw4 = new Zawody(1);
            Zawody zaw5 = new Zawody(8);
            Zawody zaw6 = new Zawody(7);
            ArrayList list = new ArrayList();
            list.Add(zaw1);
            list.Add(zaw2);
            list.Add(zaw3);
            list.Add(zaw4);
            list.Add(zaw5);
            list.Add(zaw6);

            LinkedList<string> linked = new LinkedList<string>();
            linked.AddLast("aaaa");
            linked.AddLast("bbb");
            linked.AddLast("ccccc");
            linked.AddLast("ddd");
            linked.AddLast("eeeee");
          
        }
    }
}
