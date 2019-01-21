using System.Collections.Generic;
using Common;
namespace ABC___BL
{
    public class Klient : KlasaBazowa, ILogowanie
    { 
        public Klient() : this (0)
        {
            
        }

        public Klient(int KlientId)
        {
            this.KlientId = KlientId;
            ListaAdresow = new List<Adres>();
        }

        public List<Adres> ListaAdresow { get; set; }


        public static int Licznik { get; set; }


        private string _nazwisko;
        public string Nazwisko
        {
            get
            {
                //tutaj dowolny kod
                return _nazwisko;
            }
            set
            {
                _nazwisko = value;
            }
        }

        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwisko
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Nazwisko) && string.IsNullOrWhiteSpace(Imie)) return ", ";
                else if (string.IsNullOrWhiteSpace(Nazwisko)) return Imie;
                else if (string.IsNullOrWhiteSpace(Imie)) return Nazwisko;
                else return Imie + ", " + Nazwisko;
            }

            
        }
        public int KlientTyp { get; set; }

        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(Nazwisko) || string.IsNullOrWhiteSpace(Email))
                poprawne = false;
            return poprawne;
        }

        /// <summary>
        /// Zapisujemy obecnego klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //kod zapisuje zdefiniowanego klienta
            return true;
        }

        public Klient Pobierz(int KlientId)
        {
            //kod ktory pobiera okreslonego klienta
            return new Klient();
        }

        public List<Klient> Pobierz()
        {
            //kod ktory pobiera wszystkich klientow

            return new List<Klient>();
        }

        public override string ToString()
        {
            return ImieNazwisko;
        }

        public string Log()
        {
            var logTest = KlientId + ": " + ImieNazwisko + " " + "Email: " + Email + " " + "Status: " + StanObiektu.ToString();
            return logTest;
        }
    }
}
