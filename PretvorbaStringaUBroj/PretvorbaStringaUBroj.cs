using System;
using System.Globalization;

namespace Vsite.CSharp.RadSTekstom
{
    class PretvorbaStringaUBroj
    {
        // :040 Dodati u donju metodu poziv metode Parse koja će tekst pretvoriti u double i vratiti rezultat. Pokrenuti program i provjeriti ispise.
        public static double UDouble(string tekst)
        {
            return double.Parse(tekst);
        }

        // :041 Dodati u donju metodu poziv metode Parse koja kao drugi argument prima IFormatProvider i vratiti rezultat. Pokrenuti program i provjeriti ispise
        public static double UDouble(string tekst, IFormatProvider formatProvider)
        {
            return double.Parse(tekst, formatProvider);
        }

        // :042 Dodati u donju metodu poziv metode TryParse. Ako je pretvorba uspjela, ispisati rezultat, inače ispisati poruku "Neuspješno". Pokrenuti program i provjeriti ispise
        public static void PokušajUDouble(string tekst)
        {
            double rezultat;
            
            if (double.TryParse(tekst, out rezultat))
                Console.WriteLine(rezultat);
            else
            {
                Console.WriteLine("Neuspješno");
            }
        }

        private static void PretvoriStringUDabl(string tekst)
        {
            try
            {
                Console.Write($@"Parsiramo tekst ""{tekst}"" u tip double: ");
                double broj = UDouble(tekst);
                Console.WriteLine(broj);
            }
            catch (Exception e)
            {
                Console.WriteLine($"POGREŠKA: {e.Message}");
            }
        }
        private static void PretvoriStringUDabl(string tekst, IFormatProvider formatProvider)
        {
            try
            {
                Console.Write($@"Parsiramo tekst ""{tekst}"" u tip double: ");
                double broj = UDouble(tekst, formatProvider);
                Console.WriteLine(broj);
            }
            catch (Exception e)
            {
                Console.WriteLine($"POGREŠKA: {e.Message}");
            }
        }

        // :043 Pokrenuti testove (4 testa u grupi "TestStringUBroj" moraju proći)
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string sDecimalnomTočkom = "1.234";
            string sDecimalnimZarezom = "1,234";
            string neštoŠtoNijeBroj = "1,234A";

            Console.WriteLine($"*** Koristimo trenutnu kulturu {CultureInfo.CurrentCulture}:");
            PretvoriStringUDabl(sDecimalnomTočkom);
            PretvoriStringUDabl(sDecimalnimZarezom);
            PretvoriStringUDabl(neštoŠtoNijeBroj);

            Console.WriteLine("*** Mijenjamo kulturu u en-US:");
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            PretvoriStringUDabl(sDecimalnomTočkom);
            PretvoriStringUDabl(sDecimalnimZarezom);

            Console.WriteLine("*** Mijenjamo kulturu u de-DE:");
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");
            PretvoriStringUDabl(sDecimalnomTočkom);
            PretvoriStringUDabl(sDecimalnimZarezom);

            Console.WriteLine("*** Idemo s InvariantCulture:");
            PretvoriStringUDabl(sDecimalnomTočkom, CultureInfo.InvariantCulture);
            PretvoriStringUDabl(sDecimalnimZarezom, CultureInfo.InvariantCulture);

            Console.WriteLine("*** Idemo s TryParse:");
            try
            {
                PokušajUDouble(sDecimalnomTočkom);
                PokušajUDouble(sDecimalnimZarezom);
                PokušajUDouble(neštoŠtoNijeBroj);
            }
            catch (Exception e)
            {
                Console.WriteLine($"POGREŠKA: {e.Message}");
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(false);
        }
    }
}
