using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.RadSTekstom
{
    class KodiranjaTeksta
    {
        // :060 Pokrenuti program i provjeriti kako pretvorbe u pojedine kodne stranice utječu na prikaz jezično-specifičnih znakova

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // kodiramo u ASCII; budući da nema "naših" znakova sve će biti ispravno
            string tekst1 = "Dobar dan!";
            IspišiKodirajDekodiraj(tekst1, Encoding.ASCII);

            // ako imamo "naše" znakove, ASCII kodiranje će ih neće moći pretvoriti u ASCII pa će ih pretvoriti u upitnike
            string tekst2 = "Đakovački?";
            IspišiKodirajDekodiraj(tekst2, Encoding.ASCII);

            // kodiramo u Unicode; svi znakovi zauzimaju 2 bajta pa je kodirani niz dulji
            IspišiKodirajDekodiraj(tekst1, Encoding.Unicode);

            // naše znakove će Unicode i UTF-8 ispravno obraditi
            IspišiKodirajDekodiraj(tekst2, Encoding.Unicode);

            IspišiKodirajDekodiraj(tekst1, Encoding.UTF8);
            IspišiKodirajDekodiraj(tekst2, Encoding.UTF8);

            // primjer znaka koji u UTF-16 zauzima 4 bajta
            string tekst3 = "😀";
            IspišiKodirajDekodiraj(tekst3, Encoding.Unicode);
            IspišiKodirajDekodiraj(tekst3, Encoding.UTF8);

            // :061 Pogledati sadržaje triju datoteka te identificirati BOM-ove u Unicode i UTF8 datotekama.
            // Zapišimo isti tekst u tri datoteke s različitim kodiranjima
            PohraniNaDisk("Đakovački ASCII.txt", Encoding.ASCII, tekst2);
            PohraniNaDisk("Đakovački Unicode.txt", Encoding.Unicode, tekst2);
            PohraniNaDisk("Đakovački UTF8.txt", Encoding.UTF8, tekst2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(false);
        }

        static void IspišiBajtove(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            foreach (byte b in bytes)
            {
                Console.Write(string.Format("0x{0:X2} ", b));
            }
            Console.WriteLine();
        }

        static void IspišiKodirajDekodiraj(string tekst, Encoding kodiranje)
        {
            // ispišimo kodiranje koje će se koristiti
            Console.WriteLine(string.Format($"*** Kodiranje: {kodiranje.HeaderName} ***"));
            Console.WriteLine($"Originalni tekst:   {tekst}");

            // ispišimo sadržaj memorije (kako je tekst pohranjen u memoriji)
            Console.Write("Bajtovi u memoriji: ");
            IspišiBajtove(tekst);

            // iz teksta stvaramo niz bajtova u zadanom kodiranju
            byte[] bajtovi = kodiranje.GetBytes(tekst);
            // ispišimo bajtove u zadanom kodiranju
            Console.Write("Kodirani bajtovi:   ");
            foreach (byte b in bajtovi)
                Console.Write(string.Format("0x{0:X2} ", b));
            Console.WriteLine();

            // dekodirane bajtove pretvaramo nazad u string prema zadanom kodiranju
            Console.WriteLine($"Dekodirani string:  {kodiranje.GetString(bajtovi)}");

            // za usporedbu ispisujemo i pojedine bajtove
            Console.Write("Dekodirani bajtovi: ");
            foreach (byte b in bajtovi)
                Console.Write(string.Format("0x{0:X2} ", b));
            Console.WriteLine(Environment.NewLine);
        }

        static void PohraniNaDisk(string ime, Encoding kodiranje, string tekst)
        {
            using (FileStream fs = new FileStream(ime, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs, kodiranje))
                {
                    sw.Write(tekst);
                }
            }
        }
    }
}
