using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.RadSTekstom.Testovi
{
    [TestClass]
    public class LeksičkaUsporedba : ConsoleTest
    {
        [TestMethod]
        public void CompareToVraćaDaJeLjubavIzaLukavZaHrvatskeLokalizacijskePostavke()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hr-HR");
            LeksičkeUsporedbe.PozivCompareTo("ljubav", "lukav");
            Assert.AreEqual("ljubav > lukav", cw.GetString());
        }

        [TestMethod]
        public void CompareToDaJeRiječSVelikmPočetnimSlovomIzaIsteRiječiSMalimPočetnimSlovom()
        {
            LeksičkeUsporedbe.PozivCompareTo("Pero", "pero");
            Assert.AreEqual("Pero > pero", cw.GetString());
            LeksičkeUsporedbe.PozivCompareTo("pero", "Pero");
            Assert.AreEqual("pero < Pero", cw.GetString());
        }

        [TestMethod]
        public void CompareToVraćaDaJeLjubavIspredLukavZaBritanskeLokalizacijskePostavke()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-UK");
            LeksičkeUsporedbe.PozivCompareTo("ljubav", "lukav");
            Assert.AreEqual("ljubav < lukav", cw.GetString());
        }

        [TestMethod]
        public void CompareVraćaDaJeLjubavIzaLukavZaHrvatskeLokalizacijskePostavke()
        {
            LeksičkeUsporedbe.PozivCompareBezRazlikeMalaVelikaSlova("Ljubav", "lukav", new System.Globalization.CultureInfo("hr-HR"));
            Assert.AreEqual("Ljubav > lukav", cw.GetString());
        }

        [TestMethod]
        public void CompareVraćaDaJeLjubavIspredLukavZaNjemačkeLokalizacijskePostavke()
        {
            LeksičkeUsporedbe.PozivCompareBezRazlikeMalaVelikaSlova("Ljubav", "lukav", new System.Globalization.CultureInfo("de-DE"));
            Assert.AreEqual("Ljubav < lukav", cw.GetString());
        }

        [TestMethod]
        public void CompareVraćaDaJeStrasseJednakoStraßeZaNjemačkeLokalizacijskePostavke()
        {
            LeksičkeUsporedbe.PozivCompareBezRazlikeMalaVelikaSlova("strasse", "Straße", new System.Globalization.CultureInfo("de-DE"));
            Assert.AreEqual("strasse == Straße", cw.GetString());
        }

        [TestMethod]
        public void CompareOrdinalVraćaDaJeRiječSVelikmPočetnimSlovomIspredIsteRiječiSMalimPočetnimSlovom()
        {
            LeksičkeUsporedbe.PozivCompareOrdinal("Pero", "pero");
            Assert.AreEqual("Pero < pero", cw.GetString());
            LeksičkeUsporedbe.PozivCompareOrdinal("pero", "Pero");
            Assert.AreEqual("pero > Pero", cw.GetString());
        }
    }
}
