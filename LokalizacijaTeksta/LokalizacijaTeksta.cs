using System;

namespace Vsite.CSharp.RadSTekstom
{
    public class LokalizacijaTeksta
    {
        // TODO:080 Pokrenuti program i provjeriti rezultat ispisa (uneseni državni kod nema nikakvog utjecaja!).
        // TODO:081 Otvoriti u FileExploreru kazalo projekta te pogledati sadržaj potkazala bin\Debug
        // TODO:082 Unutar projekta napraviti presliku datoteke Poruke.resx i preimenovati kopiju u Poruke.hr.resx
        // TODO:083 U Poruke.hr.resx promijeniti vrijednost resursa "Pozdrav" u "Dobar dan!", a resursa "KakoSte" u "Kako ste?" (bez navodnika)
        // TODO:084 Pokrenuti program i kraticu jezik upisati "hr" (bez navodnika) te provjeriti ispis
        // TODO:085 Provjeriti do kojih je promjena došlo u kazalu bin\Debug
        // TODO:086 Na sličan način dodati prijevod za njemački (kratica "de", prijevod "Guten Tag!", odn. "Wie geht's?")
        // TODO:087 Pokrenuti testove (3 testa u grupi "TestLokalizacijeTeksta" moraju proći)

        public static string? LokaliziranaPoruka(string poruka, string oznakaJezika)
        {
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo(oznakaJezika);

            System.Resources.ResourceManager resursi = new System.Resources.ResourceManager("Vsite.CSharp.RadSTekstom.Poruke", System.Reflection.Assembly.GetExecutingAssembly());

            return resursi.GetString(poruka, ci);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Poruke.UpišiteKraticuJezika); // primjer izravnog dohvaćanja resursa
                var oznakaJezika = Console.ReadLine();
                if (oznakaJezika != null)
                {
                    // primjer poziva bez promjene aktivnih lokalizacijskih postavki
                    Console.WriteLine(LokaliziranaPoruka("Pozdrav", oznakaJezika));
                    // primjer poziva tako da promijenimo aktivne lokalizacijske postavke
                    Console.WriteLine(LokaliziranaPoruka("KakoSte", oznakaJezika));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
