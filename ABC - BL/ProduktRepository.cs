using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC___BL
{
    public class ProduktRepository
    {

        /// <summary>
        /// Pobieramy jeden produkt
        /// </summary>
        /// <param name="produktID"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktID)
        {
            //tworzymy instancje klasy produkt i przekazujemy identyfikator
            Produkt produkt = new Produkt(produktID);

            Object mojObiekt = new Object();

            Console.WriteLine("Obiekt: " + mojObiekt.ToString());
            Console.WriteLine("Produkt: " + produkt.ToString());
            //Kod, ktory pobiera zdefiniowany produkt

            //tymczasowe zakodowane wartosci, aby zrocic produkt

            if (produktID == 1)
            {
                produkt.NazwaProduktu = "Zabawki";
                produkt.Opis = "Klocki";
                produkt.AktualnaCena = 119.99M;
            }

            //kod ktory pobiera zdefiniowany produkt
            return produkt;
        }

        /// <summary>
        /// Zapisujemy biezacy produkt
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public bool Zapisz(Produkt produkt)
        {
            //kod ktory zapisuje zdefiniowany produkt
            var Sukces = true;

            if(produkt.MaZmiany && produkt.DaneSaPrawidlowe)
            {
                if (produkt.JestNowy)
                {
                    //wywolujemy procedure skladowa insert
                }
                else
                {
                    //wywolujemy procerure skladowa update
                }
            }

            return Sukces;
        }
    }
}
