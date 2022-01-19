using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Vsite.CSharp.RadSTekstom.Testovi
{
    [TestClass]
    public class StringBuilder
    {
        [TestMethod]
        public void StringBuilderSlažeAbeceduBržeOdObičnogNadovezivanjaStringa()
        {
            Assert.AreEqual(Vsite.CSharp.RadSTekstom.StringBuilder.SložiAbeceduObično(), Vsite.CSharp.RadSTekstom.StringBuilder.SložiAbeceduStringBuilderom());

            Stopwatch štoperica = new Stopwatch();
            štoperica.Start();
            Vsite.CSharp.RadSTekstom.StringBuilder.SložiAbeceduObično();
            štoperica.Stop();
            var vrijeme1 = štoperica.ElapsedTicks;

            štoperica.Restart();
            Vsite.CSharp.RadSTekstom.StringBuilder.SložiAbeceduStringBuilderom();
            štoperica.Stop();
            var vrijeme2 = štoperica.ElapsedTicks;

            Assert.IsTrue(vrijeme1 > 3 * vrijeme2);
        }
    }
}
