using System;

namespace Vsite.CSharp.RadSTekstom
{
    class Unicode
    {
        //:000 Pogledati imena donjih varijabli te sadržaje tekstova
        //:001 Pokrenuti program i provjeriti ispis
        static void Main(string[] args)
        {
            //:002 Otkomentirati donju naredbu i ponovno pokrenuti program te provjeriti ispis
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // latinica
            string varijabla = "Đakovački Božić u šumi";
            Console.WriteLine(varijabla);

            // ćirilica
            double варијабла = Math.PI;
            Console.WriteLine(варијабла);

            // japanski
            int int変数 = 25;
            Console.WriteLine(int変数);

            string 変数 = "変数の宣言と代入と参照";
            Console.WriteLine(変数);

            //:003 Selektirati prethodne dvije naredbe i iz kontekstnog izbornika odabrati naredbu "Execute in interactive" te provjeriti ispis

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
