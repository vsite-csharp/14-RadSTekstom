using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.RadSTekstom.Testovi
{
    [TestClass]
    public class TestLokalizacijeTeksta
    {
        [TestMethod]
        public void LokaliziranaPorukaVraćaHrvatskiPozdravZaZadanuKraticuHrvatske()
        {
            Assert.AreEqual("Dobar dan!", LokalizacijaTeksta.LokaliziranaPoruka("Pozdrav", "hr"), true);
        }

        [TestMethod]
        public void LokaliziranaPorukaVraćaNjemačkiPozdravZaZadanuKraticuNjemačke()
        {
            Assert.AreEqual("Guten Tag!", LokalizacijaTeksta.LokaliziranaPoruka("Pozdrav", "de"), true);
        }

        [TestMethod]
        public void LokaliziranaPorukaVraćaHrvatskiUpitZaZadanuKraticuHrvatske()
        {
            Assert.AreEqual("Kako ste?", LokalizacijaTeksta.LokaliziranaPoruka("KakoSte", "hr"), true);
        }
    }
}
