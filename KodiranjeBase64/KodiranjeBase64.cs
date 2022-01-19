using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.RadSTekstom
{
    public class KodiranjeBase64
    {
        static void IspišiBajtove(byte[] bajtovi, int bajtovaURetku)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder(bajtovaURetku * 5);
            foreach (byte b in bajtovi)
            {
                sb.AppendFormat("0x{0:X2} ", b);
                if (++i >= bajtovaURetku)
                {
                    Console.WriteLine(sb.ToString());
                    sb.Clear();
                    i = 0;
                }
            }
            Console.WriteLine();
        }

        static void IspišiZnakove(string tekst, int znakovaURetku)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder(znakovaURetku);
            foreach (char ch in tekst)
            {
                sb.Append(ch);
                if (++i >= znakovaURetku)
                {
                    Console.WriteLine(sb.ToString());
                    sb.Clear();
                    i = 0;
                }
            }
            Console.WriteLine();
        }

        public static void NapraviBase64Konverzije()
        {
            // Učitavamo binarnu datoteku, tj.datoteku koja sadrži i bajtove koji ne predstavljaju niti
            // jedan od znakova koji se može prikazati (slovo, znamenku, interpunkciju).
            byte[] bajtovi = null;
            using (FileStream datoteka = new FileStream("Icon.ico", FileMode.Open, FileAccess.Read))
            {
                bajtovi = new Byte[datoteka.Length];
                datoteka.Read(bajtovi, 0, (int)datoteka.Length);
            }

            // Prikazujemo pojedine bajtove u heksadekadskom formatu.
            Console.WriteLine($"*** Originalni bajtovi (duljina={bajtovi.Length} bajtova): ***");
            IspišiBajtove(bajtovi, 16);
            Console.WriteLine();

            // Bajtove kodiramo u Base-64, tj. niz znakova koji se vide u bilo koji programu za prikaz i uređivanje teksta.
            string base64 = Convert.ToBase64String(bajtovi, 0, bajtovi.Length);

            // Ispisujemo pojedine znakove Base-64 kodiranog niza.
            Console.WriteLine($"*** Kodirano u Base-64 (duljina={base64.Length} znaka): ***");
            IspišiZnakove(base64, 64);
            Console.WriteLine();

            // TODO:101 Dodati naredbu koja će niz base64 konvertirati iz Base-64 kodiranja u niz bajtova dekodiraniBajtovi te otkomentirati donje naredbe da se ispiše rezultat konverzije.

            //Console.WriteLine($"*** Bajtovi dekodirani iz Base-64 (duljina={dekodiraniBajtovi.Length} bajtova): ***");
            //IspišiBajtove(dekodiraniBajtovi, 16);
            Console.WriteLine();

            // TODO:102 Pokrenuti i provjeriti prolazi li test u grupi KodiranjeBase64.
        }

        // TODO:100 Pokrenuti program i pogledati što će se ispisati.
        static void Main(string[] args)
        {
            NapraviBase64Konverzije();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
