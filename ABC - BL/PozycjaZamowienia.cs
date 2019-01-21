using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC___BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {

        }

        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            PozycjaZamowieniaId = pozycjaZamowieniaId;
        }

        public int PozycjaZamowieniaId { get; private set; }

        public int Ilosc { get; set; }

        public int ProduktID { get; set; }

        public decimal? CenaZakupu { get; set; }

        /// <summary>
        /// Pobieramy jedno pozycje zamowienie
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowienieID)
        {
            //kod ktory pobiera zdefiniowany element zamowienie
            return new PozycjaZamowienia();
        }

        /// <summary>
        /// Zapisujemy biezacy element zamowienie
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public bool Zapisz()
        {
            //kod ktory zapisuje zdefiniowany element zamowienie
            return true;
        }
        /// <summary>
        /// Sprawdzamy dane pozycji zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;
            if (Ilosc <= 0 || ProduktID <= 0 || CenaZakupu == null)
                poprawne = false;
            return poprawne;
        }
    }
}
