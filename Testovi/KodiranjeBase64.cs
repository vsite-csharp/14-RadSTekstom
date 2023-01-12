using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace Vsite.CSharp.RadSTekstom.Testovi
{
    [TestClass]
    public class KodiranjeBase64 : ConsoleTest
    {
        private void PreskočiNaslov()
        {
            var učitano = cw?.GetString();
            while (!učitano.StartsWith("*** "))
            {
                učitano = cw?.GetString();
            }
        }

        private string UčitajBlok()
        {
            System.Text.StringBuilder tekst = new System.Text.StringBuilder(); 
            string? učitano;
            while ((učitano = cw?.GetString()).Length > 0)
            {
                tekst.Append(učitano);
            }
            return tekst.ToString();
        }

        [TestMethod]
        public void PovratnaKonverzijaVraćaIzvorniNizBajtova()
        {
            Vsite.CSharp.RadSTekstom.KodiranjeBase64.NapraviBase64Konverzije();
            Assert.IsTrue(cw?.Count > 45);

            PreskočiNaslov();
            var početni = UčitajBlok();

            PreskočiNaslov();
            UčitajBlok();

            PreskočiNaslov();
            var dekodirani = UčitajBlok();

            Assert.AreEqual(početni, dekodirani);
        }
    }
}
