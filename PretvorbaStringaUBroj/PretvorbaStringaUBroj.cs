using System;
using System.Globalization;

namespace Vsite.CSharp.RadSTekstom
{
    class PretvorbaStringaUBroj
    {
        public static double UDouble(string tekst)
        {
            return double.Parse(tekst);
        }

        public static double UDouble(string tekst, IFormatProvider formatProvider)
        {
            return double.Parse(tekst, formatProvider);
        }

        public static void PokušajUDouble(string tekst)
        {
            double br;
            bool uspjelo=double.TryParse(tekst, out br);
            if (uspjelo)
            {
                Console.WriteLine(br);
            }
            else
            {
                Console.WriteLine("Neuspješno");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                double broj = UDouble("1.234");
                Console.WriteLine(broj);
            }
            catch (Exception e)
            {
                Console.WriteLine("POGREŠKA:");
                Console.WriteLine(e.Message);
            }

            try
            {
                double broj = UDouble("1,234");
                Console.WriteLine(broj);
            }
            catch (Exception e)
            {
                Console.WriteLine("POGREŠKA:");
                Console.WriteLine(e.Message);
            }

            try
            {
                CultureInfo ci = CultureInfo.InvariantCulture;
                double broj = UDouble("1.234", ci);
                Console.WriteLine(broj);
            }
            catch (Exception e)
            {
                Console.WriteLine("POGREŠKA:");
                Console.WriteLine(e.Message);
            }

            try
            {
                PokušajUDouble("1.234");
                PokušajUDouble("1,234");
                PokušajUDouble("1.234A");
            }
            catch (Exception e)
            {
                Console.WriteLine("POGREŠKA:");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(false);
        }
    }
}
