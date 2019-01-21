using System;
using System.Collections.Generic;
using ABC___BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC_BLtest
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienie()
        {
            //arrange
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new Zamowienie(1)
            {
                DataZamowienia = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };
            //act
            var aktualna = zamowienieRepository.Pobierz(1);
            //assert
            Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
        }

        [TestMethod]
        public void PobierzZamowienieDoWyswietleniatest()
        {
            //arrange
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new WyswietlanieZamowienia()
            {
                Imie = "Marcin",
                Nazwisko = "Nowak",
                AdresDostawy = new Adres()
                {
                    AdresTyp = 1,
                    Ulica = "Kosmiczna",
                    Miasto = "Katowice",
                    KodPocztowy = "40-467",
                    Kraj = "Polska"
                },
                DataZamowienia = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>()
                {
                    new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Krzeslo",
                        IloscZamowienia = 4,
                        CenaZakupu = 119.77M

                    },

                    new WyswietlaniePozycjiZamowienia()
                    {
                    NazwaProduktu = "Stolik",
                    IloscZamowienia = 7,
                    CenaZakupu = 249M

                    },


                }
            };
            //act
            var aktualna = zamowienieRepository.PobierzZamowienieDoWyswietlenia(10);
            //assert
            Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            Assert.AreEqual(oczekiwana.AdresDostawy.AdresTyp, aktualna.AdresDostawy.AdresTyp);
            Assert.AreEqual(oczekiwana.AdresDostawy.Ulica, aktualna.AdresDostawy.Ulica);
            Assert.AreEqual(oczekiwana.AdresDostawy.Miasto, aktualna.AdresDostawy.Miasto);
            Assert.AreEqual(oczekiwana.AdresDostawy.KodPocztowy, aktualna.AdresDostawy.KodPocztowy);
            Assert.AreEqual(oczekiwana.AdresDostawy.Kraj, aktualna.AdresDostawy.Kraj);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu, aktualna.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].IloscZamowienia, aktualna.WyswietlaniePozycjiZamowieniaLista[i].IloscZamowienia);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu, aktualna.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].PozycjaZamowieniaId, aktualna.WyswietlaniePozycjiZamowieniaLista[i].PozycjaZamowieniaId);
            }

        }
    }
}
