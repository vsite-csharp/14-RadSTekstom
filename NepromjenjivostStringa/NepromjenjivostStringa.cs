namespace Vsite.CSharp.RadSTekstom
{
    class NepromjenjivostStringa
    {
        public static void PromjeneTeksta()
        {
            // TODO:010 Pogledati kako je definirana klasa String: https://docs.microsoft.com/en-us/dotnet/api/system.string
            // TODO:011 Pokrenuti program i provjeriti ispis.

            string tekst = "Dobar ";
            string tekstPreslika = "Dobar ";

            // TODO:012 Postaviti točku prekida (breakpoint) na donju naredbu, pokrenuti program i kada se izvođenje zaustavi, dodati u prozor Watch prikaz *&tekst i *&tekstPreslika (adrese na kojima je pohranjen sadržaj stringa).
            // TODO:013 Otvoriti prozor sa sadržajem memorije (Debug-Windows-Memory-Memory1) to postaviti adresu na vrijednost koju prikazuje *&tekst, odnosno *&tekstPreslika tako da se vide memorijski sadržaji za tekst i tekstPreslika.
            // TODO:014 Pogledati gornje adrese i što se događa s njima i memorijom na tim adresama tijekom izvođenja donje naredbe. 
            tekst += "dan!";

            Console.WriteLine(tekstPreslika[3]);
            // TODO:015 Otkomentirati donju naredbu i provjeriti može li se program prevesti. 
            //tekstPreslika[1] = 'a';
            // TODO:016 Postaviti točku prekida na donju naredbu i pogledati što se događa s adresama i memorijom na adresama varijabli tijekom izvođenja donje naredbe. 
            tekstPreslika.Replace('o', 'a');
            // TODO:017 Promijeniti gornju naredbu tako da se sadržaj varijable tekstPreslika doista promijeni.
            // TODO:018 Postaviti točku prekida na naredbu i pogledati što se događa s adresama varijable testPreslika pri pozivu metode string.Replace.
            // TODO:019 Pokrenuti testove i provjeriti prolazi li test u grupi NepromjenjivostStringa.

            Console.WriteLine(tekst);
            Console.WriteLine(tekstPreslika);
        }
        static void Main()
        {
            PromjeneTeksta();

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
