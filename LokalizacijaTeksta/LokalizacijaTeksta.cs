using System;

namespace Vsite.CSharp.RadSTekstom
{
    public class LokalizacijaTeksta
    {
        //  Pokrenuti program i provjeriti rezultat ispisa (uneseni državni kod nema nikakvog utjecaja!).
        //  Otvoriti u FileExploreru kazalo projekta te pogledati sadržaj potkazala bin\Debug
        //  Unutar projekta napraviti presliku datoteke Poruke.resx i preimenovati kopiju u Poruke.hr.resx
        //  U Poruke.hr.resx promijeniti vrijednost resursa "Pozdrav" u "Dobar dan!", a resursa "KakoSte" u "Kako ste?" (bez navodnika)
        //  Pokrenuti program i kraticu jezik upisati "hr" (bez navodnika) te provjeriti ispis
        //  Provjeriti do kojih je promjena došlo u kazalu bin\Debug
        //  Na sličan način dodati prijevod za još neki jezin, npr. njemački (kratica "de", prijevod "Guten Tag!")

        public static string LokaliziranaPoruka(string poruka, string oznakaJezika)
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
                string oznakaJezika = Console.ReadLine();
                // primjer poziva bez promjene aktivnih lokalizacijskih postavki
                Console.WriteLine(LokaliziranaPoruka("Pozdrav", oznakaJezika));
                // primjer poziva tako da promijenimo aktivne lokalizacijske postavke
                Console.WriteLine(LokaliziranaPoruka("KakoSte", oznakaJezika));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
