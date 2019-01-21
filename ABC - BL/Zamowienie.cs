using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC___BL
{
    public class Zamowienie : KlasaBazowa, ILogowanie
    {
        public Zamowienie()
        {

        }

        public Zamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }

        public int ZamowienieId { get; private set; }

        public DateTimeOffset? DataZamowienia { get; set; }

        public List<PozycjaZamowienia> pozycjeZamowienia { get; set; }

        public int KlientId { get; set; }

        public int AdresDostawyId { get; set; }



        /// <summary>
        /// Pobieramy jedno zamowienie
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieID)
        {
            //kod ktory pobiera zdefiniowany zamowienie
            return new Zamowienie();
        }

        /// <summary>
        /// Zapisujemy biezace zamowienie
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public bool Zapisz()
        {
            //kod ktory zapisuje zdefiniowanezamowienie
            return true;
        }
        /// <summary>
        /// Sprawdzamy dane zamowienia
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (DataZamowienia == null)
                poprawne = false;
            return poprawne;
        }


        public override string ToString()
        {
            return DataZamowienia.Value.Date + " (" + ZamowienieId + ")";
        }

        public string Log()
        {
            var logTekst = ZamowienieId + ": " + "Data: " + DataZamowienia + " " + "Status: " + StanObiektu.ToString();
            return logTekst;
        }
    }
}
