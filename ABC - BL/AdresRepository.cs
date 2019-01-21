using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC___BL
{
    class AdresRepository
    {
        /// <summary>
        /// Pobieramy jeden adres.
        /// </summary>
        /// <param name="adresId"></param>
        /// <returns></returns>
        public Adres Pobierz(int adresId)
        {
            //tworzymy instancje klasy Adres i przekazujemy zadany identyfikator
            Adres adres = new Adres(adresId);

            //Kod ktory pobiera zdefiniowany adres

            //Tymczasowo zakodowane wartosci do zwrocenia adresu
            if (adresId == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Goscinna";
                adres.Miasto = "Katowice";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "40-467";
            }

            return adres;
        }
        /// <summary>
        /// Pobieramy wszystkie zdefiniowane adresy dla klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public IEnumerable<Adres> PobierzPoKlientId(int klientId)
        {
            //Kod, ktory pobiera zdefiniowane adresy dla klienta

            //Tymczasowo zakodowane wartosci do zwrocenia, zestaw adresow dla klienta

            var adresList = new List<Adres>();

            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "Goscinna",
                Miasto = "Katowice",
                KodPocztowy = "40-476",
                Kraj = "Polska"
            };
            adresList.Add(adres);


            adres = new Adres(2)
            {
                AdresTyp = 2,
                Ulica = "Kosmiczna",
                Miasto = "Krakow",
                KodPocztowy = "22-321",
                Kraj = "Polska"
            };

            adresList.Add(adres);

            return adresList;
        }

        /// <summary>
        /// Zapisuje aktualny adres
        /// </summary>
        /// <param name="adres"></param>
        /// <returns></returns>
        public bool Zapisz(Adres adres)
        {
            //kod, ktory zapisuje zdefiniowany adres
            return true;
        }
    }
}
