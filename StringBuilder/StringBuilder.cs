﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.RadSTekstom
{
    public class StringBuilder
    {
        public static string SložiAbeceduObično()
        {
            string abeceda = "";
            for (char c = 'A'; c <= 'Z'; ++c)
                abeceda += c;
            for (char c = 'a'; c <= 'z'; ++c)
                abeceda += c;
            return abeceda;
        }

        // :090 Implementirati metodu SložiAbeceduStringBuilderom tako da slova abecede nadovezuje korištenjem klase System.Text.StringBuilder.
        // :091 Pokrenuti program i provjeriti ispravnost rezultata metode.
        // :092 Usporediti ispise vremena izvođenja metoda. Ponovno pokrenuti program bez debuggiranja (Ctrl+F5) i usporediti ispise.
        // :093 Pokrenuti testove i provjeriti prolazi li test u grupi StringBuilder.
        public static string SložiAbeceduStringBuilderom()
        { 
            var abeceda = new System.Text.StringBuilder(52);
            for (char c = 'A'; c <= 'Z'; ++c)
                abeceda.Append(c);
            for (char c = 'a'; c <= 'z'; ++c)
                abeceda.Append(c);
            return abeceda.ToString();

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Stopwatch štoperica = new Stopwatch();
            štoperica.Start();
            Console.WriteLine($"Abeceda složena obično:          {SložiAbeceduObično()}");
            Console.WriteLine($"Abeceda složena StringBuilderom: {SložiAbeceduStringBuilderom()}");
            štoperica.Stop();

            Console.WriteLine();

            štoperica.Restart();
            SložiAbeceduObično();
            štoperica.Stop();
            Console.WriteLine($"Slaganje abecede obično:          {štoperica.ElapsedTicks}");

            štoperica.Restart();
            SložiAbeceduStringBuilderom();
            štoperica.Stop();
            Console.WriteLine($"Slaganje abecede StringBuilderom: {štoperica.ElapsedTicks}");

            štoperica.Restart();
            SložiAbeceduStringBuilderom();
            štoperica.Stop();
            Console.WriteLine($"Slaganje abecede StringBuilderom: {štoperica.ElapsedTicks}");

            štoperica.Restart();
            SložiAbeceduObično();
            štoperica.Stop();
            Console.WriteLine($"Slaganje abecede obično:          {štoperica.ElapsedTicks}");

            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
