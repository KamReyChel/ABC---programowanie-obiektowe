using System;
using Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC___BL
{
    public class Produkt : KlasaBazowa, ILogowanie
    {
        public Produkt()
        {

        }

        public Produkt(int produktId)
        {
            this.ProduktId = produktId;
        }

        public int ProduktId { get; private set; }

        public Decimal? AktualnaCena { get; set; }

        public string Opis { get; set; }

        private string _NazwaProduktu;

        public string NazwaProduktu
        {
            get {
                
                return _NazwaProduktu.WstawSpacje();
                }
            set { _NazwaProduktu = value; }
        }


        /// <summary>
        /// Pobieramy jeden produkt
        /// </summary>
        /// <param name="produktID"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktID)
        {
            //kod ktory pobiera zdefiniowany produkt
            return new Produkt();
        }

        /// <summary>
        /// Zapisujemy biezacy produkt
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public bool Zapisz()
        {
            //kod ktory zapisuje zdefiniowany produkt
            return true;
        }
        /// <summary>
        /// Sprawdzamy dane produktu
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;
            return poprawne;
        }

        public override string ToString()
        {
            return NazwaProduktu;
        }

        public string Log()
        {
            var LogTekst = ProduktId + ": " + NazwaProduktu + " " + "Opis: " + Opis + " " + "Status: " + StanObiektu.ToString();
            return LogTekst;
        }


    }
}
