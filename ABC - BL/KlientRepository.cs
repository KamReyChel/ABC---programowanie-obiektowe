using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC___BL
{
    public class KlientRepository
    {
        private AdresRepository adresRepository { get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }


        /// <summary>
        /// Zapisujemy obecnego klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Klient klient)
        {
            //kod ktory zapisuje zdefiniowany produkt
            var Sukces = true;

            if (klient.MaZmiany && klient.DaneSaPrawidlowe)
            {
                if (klient.JestNowy)
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
        /// <summary>
        /// Popieramy jednego klienta
        /// </summary>
        /// <param name="KlientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int KlientId)
        {
            //Tworzymy instancje klasy klient
            Klient klient = new Klient(KlientId);
            klient.ListaAdresow = adresRepository.PobierzPoKlientId(KlientId).ToList();
            //kod, ktory pobiera okreslonego klienta

            //Tymczasowo zakodowane wartosci, aby zwrocic klienta

            if (KlientId == 1)
            {
                klient.Email = "marcin@gmail.com";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Wojtyla";
            }

            //kod ktory pobiera okreslonego klienta
            return klient;
        }
        /// <summary>
        /// Ppoieramy wszystkich klientow
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            //kod ktory pobiera wszystkich klientow

            return new List<Klient>();
        }
    }
}
