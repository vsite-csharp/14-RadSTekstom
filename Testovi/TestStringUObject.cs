using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.RadSTekstom.Testovi
{
    [TestClass]
    public class TestStringUBroj : ConsoleTest
    {
        [TestMethod]
        public void UDoubleVraćaZadaniBroj()
        {
            CultureInfo ci = CultureInfo.CurrentCulture;

            CultureInfo.CurrentCulture = new CultureInfo("en");
            Assert.AreEqual(1.23, PretvorbaStringaUBroj.UDouble("1.23"));

            CultureInfo.CurrentCulture = new CultureInfo("hr");
            Assert.AreEqual(1.23, PretvorbaStringaUBroj.UDouble("1,23"));

            CultureInfo.CurrentCulture = ci;
        }

        [TestMethod]
        public void UDoubleVraćaZadaniBrojZaZadanuKulturu()
        {
            Assert.AreEqual(1.23, PretvorbaStringaUBroj.UDouble("1.23", new CultureInfo("en")));
            Assert.AreEqual(1.23, PretvorbaStringaUBroj.UDouble("1,23", new CultureInfo("hr")));
        }

        [TestMethod]
        public void PokušajUDoubleIspisujeZadaniBroj()
        {
            CultureInfo ci = CultureInfo.CurrentCulture;

            CultureInfo.CurrentCulture = new CultureInfo("en");

            PretvorbaStringaUBroj.PokušajUDouble("1.23");
            Assert.AreEqual(1.23, cw.GetDouble());

            PretvorbaStringaUBroj.PokušajUDouble("1,23");
            Assert.AreEqual(123, cw.GetDouble());


            CultureInfo.CurrentCulture = new CultureInfo("hr");
            PretvorbaStringaUBroj.PokušajUDouble("1,23");
            Assert.AreEqual(1.23, cw.GetDouble());

            PretvorbaStringaUBroj.PokušajUDouble("1.23");
            Assert.AreEqual(123, cw.GetDouble());

            CultureInfo.CurrentCulture = ci;
        }

        [TestMethod]
        public void PokušajUDoubleIspisujePogreškuZaNeispravniUnos()
        {
            PretvorbaStringaUBroj.PokušajUDouble("A");
            Assert.AreEqual("Neuspješno", cw.GetString());
        }
    }
}
