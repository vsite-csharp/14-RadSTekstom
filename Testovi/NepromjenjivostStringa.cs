using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.CSharp.RadSTekstom.Testovi
{
    [TestClass]
    public class NepromjenjivostStringa : ConsoleTest
    {
        [TestMethod]
        public void MetodaReplaceKaoRezultatVraćaNoviObjekt()
        {
            Vsite.CSharp.RadSTekstom.NepromjenjivostStringa.PromjeneTeksta();
            Assert.AreEqual(3, cw.Count);
            Assert.AreEqual('a', cw.GetChar());
            Assert.AreEqual("Dobar dan!", cw.GetString());
            Assert.AreEqual("Dabar ", cw.GetString());
        }
    }
}
