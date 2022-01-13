using System;

namespace Vsite.CSharp.RadSTekstom
{
    class NepromjenjivostStringa
    {
        static void Main(string[] args)
        {
            // Pogledati kako je definirana klasa String: https://docs.microsoft.com/en-us/dotnet/api/system.string
            // Pokrenuti program i provjeriti ispis.

            string tekst = "Dobar ";
            string tekstPreslika = tekst;

            // Postaviti točku prekida (breakpoint) na donju naredbu. Pokrenuti program i kada se izvođenje zaustavi, dodati u prozor Watch prikaz *&tekst i *&tekstPreslika (adrese na kojima je pohranjen sadržaj stringa) 
            // Otvoriti prozor sa sadržajem memorije (Debug-Windows-Memory-Memory1) to postaviti adresu na vrijednost koju prikazuje *&tekst, odnosno *&tekstPreslika tako da se vide memorijski sadržaji za tekst i tekstPreslika
            // Pogledati što se događa s gornjim memorijama tijekom izvođenja donje naredbe. 
            tekst += "dan!";

            Console.WriteLine(tekst);
            Console.WriteLine(tekstPreslika);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
