using System;

namespace Vsite.CSharp.RadSTekstom
{
    class NepromjenjivostStringa
    {
        static void Main(string[] args)
        {
            // Pogledati kako je definirana klasa String: https://docs.microsoft.com/en-us/dotnet/api/system.string

            string tekst = "Dobar ";
            string tekstPreslika = tekst;
            tekst += "dan!";

            Console.WriteLine(tekst);
            Console.WriteLine(tekstPreslika);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
