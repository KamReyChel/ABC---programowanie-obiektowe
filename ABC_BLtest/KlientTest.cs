using System;
using ABC___BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC_BLtest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            //Arrange(zaranzuj test)
            Klient klient = new Klient();
            klient.Imie = "Tomasz";
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Tomasz, Nowak";

            //Act(dzialaj)

            string aktualna = klient.ImieNazwisko;

            //Assert(potwierdz test)

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImiePusteNazwisko()
        {
            //Arrange(zaranzuj test)
            Klient klient = new Klient();
            
            klient.Nazwisko = "Nowak";
            string oczekiwana = "Nowak";

            //Act(dzialaj)

            string aktualna = klient.ImieNazwisko;

            //Assert(potwierdz test)

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImieNazwiskoPuste()
        {
            //Arrange(zaranzuj test)
            Klient klient = new Klient();

            klient.Imie = "Tomasz";
            string oczekiwana = "Tomasz";

            //Act(dzialaj)

            string aktualna = klient.ImieNazwisko;

            //Assert(potwierdz test)

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void ImiePusteNazwiskoPuste()
        {
            //Arrange(zaranzuj test)
            Klient klient = new Klient();

            string oczekiwana = ", ";

            //Act(dzialaj)

            string aktualna = klient.ImieNazwisko;

            //Assert(potwierdz test)

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange(zaranzuj test)
            Klient klient1 = new Klient();
            klient1.Imie = "Tomasz";
            Klient.Licznik += 1;

            Klient klient2 = new Klient();
            klient2.Imie = "Kamil";
            Klient.Licznik += 1;

            Klient klient3 = new Klient();
            klient3.Imie = "Wacek";
            Klient.Licznik += 1;

            //Act(dzialaj)



            //Assert(potwierdz test)

            Assert.AreEqual(3, Klient.Licznik);
        }


        [TestMethod]
        public void TestZwaliduj()
        {
            //Arrange(zaranzuj test)
            Klient klient1 = new Klient
            {
                Nazwisko = "Kowal",
                Email = "tom@gmail.com"
            };
            //Act(dzialaj)

            var Klient2 = new Klient(10);
            var klient3 = new Klient();

            //Assert(potwierdz test)

            Assert.AreEqual(true, klient1.Zwaliduj());
        }
    }
}
