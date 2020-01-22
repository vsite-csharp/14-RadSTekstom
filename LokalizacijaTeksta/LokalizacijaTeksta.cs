using System;

namespace Vsite.CSharp.RadSTekstom
{
    public class LokalizacijaTeksta
    {

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
