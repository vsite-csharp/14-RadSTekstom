﻿using System;
using System.Globalization;

namespace Vsite.CSharp.RadSTekstom
{
    class PretvorbaStringaUBroj
    {
        // Dodati u donju metodu poziv metode Parse koja će tekst pretvoriti u double i vratiti rezultat. Pokrenuti program i provjeriti ispise.
        public static double UDouble(string tekst)
        {
            return Double.Parse(tekst);
        }

        // Dodati u donju metodu poziv metode Parse koja kao drugi argument prima IFormatProvider i vratiti rezultat. Pokrenuti program i provjeriti ispise
        public static double UDouble(string tekst, IFormatProvider formatProvider)
        {
            return Double.Parse(tekst, formatProvider);
        }

        // Dodati u donju metodu poziv metode TryParse. Ako je pretvornba uspjela, ispisati rezultat, inače ispisati poruku "Neuspješno". Pokrenuti program i provjeriti ispise
        public static void PokušajUDouble(string tekst)
        {
            double result;
            if (Double.TryParse(tekst, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Neuspješno");
            }


        }

        // Pokrenuti testove (4 testa u grupi "TestStringUBroj" moraju proći)
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
