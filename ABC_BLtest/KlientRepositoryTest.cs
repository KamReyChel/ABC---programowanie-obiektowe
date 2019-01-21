using System;
using System.Collections.Generic;
using ABC___BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC_BLtest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlienta()
        {
            //arrage
            var KlientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "marcin@gmail.com",
                Imie = "Marcin",
                Nazwisko = "Wojtyla"
            };
            //act
            var aktualna = KlientRepository.Pobierz(1);


            //assert
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
        }

        [TestMethod]
        public void PobierzKlientaZAdresami()
        {
            //arrage
            var KlientRepository = new KlientRepository();

            var oczekiwana = new Klient(1)
            {
                Email = "marcin@gmail.com",
                Imie = "Marcin",
                Nazwisko = "Wojtyla",

                ListaAdresow = new List<Adres>()
                {
                    new Adres(1)
                    {
                        AdresTyp = 1,
                        Ulica = "Goscinna",
                        Miasto = "Katowice",
                        KodPocztowy = "40-476",
                        Kraj = "Polska"
                    },

                    new Adres(2)
                    {
                        AdresTyp = 2,
                        Ulica = "Kosmiczna",
                        Miasto = "Krakow",
                        KodPocztowy = "22-321",
                        Kraj = "Polska"
                    }
                }
            };


            //act
            var aktualna = KlientRepository.Pobierz(1);


            //assert
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.ListaAdresow[i].AdresTyp, aktualna.ListaAdresow[i].AdresTyp);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Ulica, aktualna.ListaAdresow[i].Ulica);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Miasto, aktualna.ListaAdresow[i].Miasto);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].KodPocztowy, aktualna.ListaAdresow[i].KodPocztowy);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Kraj, aktualna.ListaAdresow[i].Kraj);
            }
        }
    }
}
