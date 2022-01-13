using System;

namespace Vsite.CSharp.RadSTekstom
{
    class NepromjenjivostStringa
    {
        static void Main(string[] args)
        {
            // :010 Pogledati kako je definirana klasa String: https://docs.microsoft.com/en-us/dotnet/api/system.string
            // :011 Pokrenuti program i provjeriti ispis.

            string tekst = "Dobar ";
            string tekstPreslika = tekst;

            // TODO:012 Postaviti točku prekida (breakpoint) na donju naredbu. Pokrenuti program i kada se izvođenje zaustavi, dodati u prozor Watch prikaz *&tekst i *&tekstPreslika (adrese na kojima je pohranjen sadržaj stringa) 
            // TODO:013 Otvoriti prozor sa sadržajem memorije (Debug-Windows-Memory-Memory1) to postaviti adresu na vrijednost koju prikazuje *&tekst, odnosno *&tekstPreslika tako da se vide memorijski sadržaji za tekst i tekstPreslika
            // TODO:014 Pogledati što se događa s gornjim memorijama tijekom izvođenja donje naredbe. 
            tekst += "dan!";

            Console.WriteLine(tekst);
            Console.WriteLine(tekstPreslika);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
