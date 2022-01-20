using System;

namespace Vsite.CSharp.RadSTekstom
{
    class PretvorbaStringaUDatum
    {
        // 050 Provjeriti što će napraviti donje metode Parse i ParseExact.
        // https://docs.microsoft.com/en-us/dotnet/api/system.datetime.parse
        // https://docs.microsoft.com/en-us/dotnet/api/system.datetime.parseexact

        private static DateTime ParsirajDatumNeovisnoOKulturi(string tekst, string format)
        {
            return DateTime.ParseExact(tekst, format, System.Globalization.CultureInfo.InvariantCulture);
        }

        public static void ParsirajDatume()
        {
            Console.WriteLine(DateTime.Parse("12, 10, 5"));

            string datum = "12:05:2005";
            DateTime dt = ParsirajDatumNeovisnoOKulturi(datum, "dd:MM:yyyy");
            Console.WriteLine(dt);

            // 051 Popravite formate u donjim pozivima metode ParsirajDatumNeovisnoOKulturi tako da se dobivaju očekivani datumi

            datum = "12.05.5"; // Datum 12. 5. 2005.
            dt = ParsirajDatumNeovisnoOKulturi(datum, "dd.MM.y");
            Console.WriteLine(dt);

            datum = "05/27/2012"; // Datum 27. 5. 2012.
            dt = ParsirajDatumNeovisnoOKulturi(datum, "MM/dd/yyyy");
            Console.WriteLine(dt);
        }

        static void Main()
        {
            ParsirajDatume();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
