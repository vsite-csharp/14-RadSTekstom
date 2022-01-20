using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.CSharp.RadSTekstom.Testovi
{
    [TestClass]
    public class StringUDatum : ConsoleTest
    {
        [TestMethod]
        public void MetodaParseExactVraćaIspravneDatume()
        {
            try
            {
                PretvorbaStringaUDatum.ParsirajDatume();
                Assert.AreEqual(DateTime.Parse("12, 10, 5"), cw.GetDate());
                Assert.AreEqual(new DateTime(2005, 5, 12), cw.GetDate());
                Assert.AreEqual(new DateTime(2005, 5, 12), cw.GetDate());
                Assert.AreEqual(new DateTime(2012, 5, 27), cw.GetDate());
                Assert.IsTrue(cw.IsEmpty);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
