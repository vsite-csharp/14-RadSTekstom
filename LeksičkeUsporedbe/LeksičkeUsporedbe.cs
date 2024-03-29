﻿using System.Globalization;

namespace Vsite.CSharp.RadSTekstom
{
    static class LeksičkeUsporedbe
    {
        static string BrojUOdnos(int? broj)
        {
            if (!broj.HasValue)
                return "?";
            if (broj == 0)
                return "==";
            if (broj < 0)
                return "<";
            return ">";
        }

        public static void PozivCompareTo(string tekst1, string tekst2)
        {
            // TODO:030 Pozvati nestatičku metodu CompareTo i njen rezultat pridružiti varijabli usporedba. Pokrenuti program i provjeriti ispise.
            int? usporedba = null;
            string odnos = BrojUOdnos(usporedba);
            Console.WriteLine($"{tekst1} {odnos} {tekst2}");
        }

        public static void PozivCompareBezRazlikeMalaVelikaSlova(string tekst1, string tekst2, CultureInfo ci)
        {
            // TODO:031 Pozvati statičku metodu Compare i njen rezultat pridružiti varijabli usporedba (postaviti da se zanemari razlika velika/mala slova). Pokrenuti program i provjeriti ispise.
            int? usporedba = null;
            string odnos = BrojUOdnos(usporedba);
            Console.WriteLine($"{tekst1} {odnos} {tekst2}");
        }

        public static void PozivCompareOrdinal(string tekst1, string tekst2)
        {
            // TODO:032 Pozvati statičku metodu CompareOrdinal i njen rezultat pridružiti varijabli usporedba. Pokrenuti program i provjeriti ispise.
            int? usporedba = null;
            string odnos = BrojUOdnos(usporedba);
            Console.WriteLine($"{tekst1} {odnos} {tekst2}");
        }

        // TODO:033 Pokrenuti i provjeriti testove (7 testova u grupi "TestLeksičkeUsporedbe" mora proći)

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CultureInfo[] kulture = new CultureInfo[] { (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone(), new CultureInfo("hr"), new CultureInfo("de") };

            string s1 = "ljubav";
            string s2 = "lukav";

            Console.WriteLine($"Nestatička metoda CompareTo, prema kulturi {System.Threading.Thread.CurrentThread.CurrentCulture.DisplayName}:");
            PozivCompareTo(s1, s2);

            foreach (CultureInfo kultura in kulture)
            {
                Console.WriteLine($"Statička metoda Compare, prema kulturi {kultura.DisplayName}:");
                PozivCompareBezRazlikeMalaVelikaSlova(s1, s2, kultura);
            }

            s1 = "strasse";
            s2 = "Straße";
            Console.WriteLine($"Nestatička metoda CompareTo, prema kulturi {System.Threading.Thread.CurrentThread.CurrentCulture.DisplayName}:");
            PozivCompareTo(s1, s2);

            foreach (CultureInfo kultura in kulture)
            {
                Console.WriteLine($"Statička metoda Compare, prema kulturi {kultura.DisplayName}:");
                PozivCompareBezRazlikeMalaVelikaSlova(s1, s2, kultura);
            }

            Console.WriteLine($"Nestatička metoda CompareOrdinal:");
            PozivCompareOrdinal(s1, s2);

            s1 = "pero";
            s2 = "Pero";
            Console.WriteLine($"Nestatička metoda CompareTo:");
            PozivCompareTo(s1, s2);
            Console.WriteLine($"Nestatička metoda CompareOrdinal:");
            PozivCompareOrdinal(s1, s2);

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
