using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class ObslugaStringa
    {
        public static string WstawSpacje(this string zrodlo)
        {
            string wynik = string.Empty;

            if (!string.IsNullOrWhiteSpace(zrodlo))
            {
                foreach (var litera in zrodlo)
                {
                    if (char.IsUpper(litera))
                    {
                        //przycinamy spacje
                        wynik = wynik.Trim();
                        wynik += " ";

                    }
                    wynik += litera;
                }

                wynik = wynik.Trim();
            }

            return wynik;
        }
    }
}
