using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class ObslugaStringaTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {
            //arrange
            var zrodlo = "KlockiLego";
            var oczekiwana = "Klocki Lego";
            //var obslugaStringa = new ObslugaStringa();


            //act

            var aktualna = zrodlo.WstawSpacje();

            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void WstawSpacjeTestzeSpacja()
        {
            //arrange
            var zrodlo = "Klocki Lego";
            var oczekiwana = "Klocki Lego";
            //var obslugaStringa = new ObslugaStringa();


            //act

            var aktualna = zrodlo.WstawSpacje();

            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }


    }
}
