using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC___BL
{
    public class ZamowienieRepository
    {
        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieID)
        {
            //tworzymy instancje klasy zamowienia i przekazujemy identyfikator
            Zamowienie zamowienie = new Zamowienie(zamowienieID);


            //kod ktory pobiera zdefiniowany zamowienie

            //tymczasowe zakodowane wartosci zamowieniado zwrocenia
            if (zamowienieID == 1)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }


            return zamowienie;
        }

        /// <summary>
        /// Pobieramy jedno zamowienie do wyswietlenia
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieId)
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();
            //kod ktory pobiera zdefiniowane pola zamowienia

            //tymczasowedane zakodowane na stale

            if (zamowienieId==10)
            {
                wyswietlanieZamowienia.Imie = "Marcin";
                wyswietlanieZamowienia.Nazwisko = "Nowak";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                wyswietlanieZamowienia.AdresDostawy = new Adres
                {
                    AdresTyp = 1,
                    Ulica = "Kosmiczna",
                    Miasto = "Katowice",
                    KodPocztowy = "40-467",
                    Kraj = "Polska"
                };
            }

            wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>();
            //kod ktory pobiera elementy zamowienia

            //tymczasowe dane zakodowane na stale

            if (zamowienieId == 10)
            {
                var wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                {
                    NazwaProduktu = "Krzeslo",
                    IloscZamowienia = 4,
                    CenaZakupu = 119.77M

                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);

                wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                {
                    NazwaProduktu = "Stolik",
                    IloscZamowienia = 7,
                    CenaZakupu = 249M

                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);
            }

            return wyswietlanieZamowienia;
        }


        /// <summary>
        /// Zapisujemy biezace zamowienie
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public bool Zapisz(Zamowienie zamowienie)
        {
            //kod ktory zapisuje zdefiniowany produkt
            var Sukces = true;

            if (zamowienie.MaZmiany && zamowienie.DaneSaPrawidlowe)
            {
                if (zamowienie.JestNowy)
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
