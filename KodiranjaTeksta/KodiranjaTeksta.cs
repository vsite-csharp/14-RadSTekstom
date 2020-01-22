using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.RadSTekstom
{
    class KodiranjaTeksta
    {

        static void Main(string[] args)
        {
            // kodiramo u ASCII; budući da nema naših znakova 
            // sve će biti ispravno
            string tekst = "Dobar dan";
            IspišiKodirajDekodiraj(tekst, Encoding.ASCII);

            // kodiramo u Unicode; svi znakovi zauzimaju 2 bajta
            // pa je kodirani niz dulji
            IspišiKodirajDekodiraj(tekst, Encoding.Unicode);

            // ako imamo naše znakove, ASCII kodiranje će ih "progutati"
            tekst = "ama čovječe";
            IspišiKodirajDekodiraj(tekst, Encoding.ASCII);

            // naše znakove će Unicode i UTF-8 ispravno obraditi
            IspišiKodirajDekodiraj(tekst, Encoding.Unicode);

            IspišiKodirajDekodiraj(tekst, Encoding.UTF8);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(false);
        }

        static void IspišiKodirajDekodiraj(string tekst, Encoding kodiranje)
        {
            // ispišimo kodiranje koje će se koristiti
            Console.WriteLine(string.Format("*** Kodiranje: {0} ***", kodiranje.HeaderName));
            Console.WriteLine("Originalni tekst:   {0}", tekst);

            // iz teksta stvaramo niz bajtova
            byte[] bajtovi = kodiranje.GetBytes(tekst);
            // ispišimo originalne bajtove
            Console.Write("Originalni bajtovi: ");
            foreach (byte b in bajtovi)
                Console.Write(string.Format("0x{0:X} ", b));
            Console.WriteLine();

            // na bajtove primijenimo Base64 kodiranje
            string enkodirano = Convert.ToBase64String(bajtovi);
            Console.WriteLine("Tekst u Base-64:    {0}", enkodirano);

            // dekodiramo bajtove
            bajtovi = Convert.FromBase64String(enkodirano);

            // dekodirane bajtove pretvarmo u string prema zadanom kodiranju
            Console.WriteLine("Dekodirani string:  {0}", kodiranje.GetString(bajtovi));

            // za usporedbu ispisujemo i pojedine bajtove
            Console.Write("Dekodirani bajtovi: ");
            foreach (byte b in bajtovi)
                Console.Write(string.Format("0x{0:X} ", b));
            Console.WriteLine(Environment.NewLine);
        }
    }
}
