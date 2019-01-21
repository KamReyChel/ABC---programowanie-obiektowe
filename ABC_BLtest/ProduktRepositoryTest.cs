using System;
using ABC___BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC_BLtest
{
    [TestClass]
    public class ProduktRepositoryTest
    {
        [TestMethod]
        public void PobierzProdukt()
        {
            //arrange
            var produktRepository = new ProduktRepository();

            var oczekiwana = new Produkt(1)
            {
                NazwaProduktu = "Zabawki",
                Opis = "Klocki",
                AktualnaCena = 119.99M
            };


            //act
            var aktualna = produktRepository.Pobierz(1);
            //assert
            Assert.AreEqual(oczekiwana.NazwaProduktu, aktualna.NazwaProduktu);
            Assert.AreEqual(oczekiwana.Opis, aktualna.Opis);
            Assert.AreEqual(oczekiwana.AktualnaCena, aktualna.AktualnaCena);
        }
    }
}
