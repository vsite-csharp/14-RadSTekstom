using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.RadSTekstom.Testovi
{
    [TestClass]
    public class LokalizacijaTeksta
    {
        [TestMethod]
        public void LokaliziranaPorukaVraćaHrvatskiPozdravZaZadanuKraticuHrvatske()
        {
            Assert.AreEqual("Dobar dan!", RadSTekstom.LokalizacijaTeksta.LokaliziranaPoruka("Pozdrav", "hr"), true);
        }

        [TestMethod]
        public void LokaliziranaPorukaVraćaNjemačkiPozdravZaZadanuKraticuNjemačke()
        {
            Assert.AreEqual("Guten Tag!", RadSTekstom.LokalizacijaTeksta.LokaliziranaPoruka("Pozdrav", "de"), true);
        }

        [TestMethod]
        public void LokaliziranaPorukaVraćaHrvatskiUpitZaZadanuKraticuHrvatske()
        {
            Assert.AreEqual("Kako ste?", RadSTekstom.LokalizacijaTeksta.LokaliziranaPoruka("KakoSte", "hr"), true);
        }
    }
}
