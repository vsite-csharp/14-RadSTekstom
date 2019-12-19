using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.RadSTekstom.Testovi
{
    [TestClass]
    public class LokalizacijaDijaloga
    {
        LocalizedForm forma = new LocalizedForm();

        [TestInitializeAttribute]
        public void Setup()
        {
            forma.ShowInTaskbar = false;
            forma.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        [TestMethod]
        public void KadaSeJezikPromijeniUHrvatskiPrikažuSeHrvatskiPrijevodi()
        {
            forma.comboBoxLanguages.SelectedItem = "en";
            Assert.AreEqual("Main Form", forma.Text, true);
            Assert.AreEqual("Language:", forma.labelLanguage.Text, true);
            Assert.AreEqual("Hello!", forma.labelGreeting.Text, true);

            forma.comboBoxLanguages.SelectedItem = "hr";
            Assert.AreEqual("Glavna forma", forma.Text, true);
            Assert.AreEqual("Jezik:", forma.labelLanguage.Text, true);
            Assert.AreEqual("Dobar dan!", forma.labelGreeting.Text, true);
        }

        [TestMethod]
        public void KadaSeJezikPromijeniUNjemačkiPrikažuSeNjemačkiPrijevodi()
        {
            forma.comboBoxLanguages.SelectedItem = "en";
            Assert.AreEqual("Main Form", forma.Text, true);
            Assert.AreEqual("Language:", forma.labelLanguage.Text, true);
            Assert.AreEqual("Hello!", forma.labelGreeting.Text, true);

            forma.comboBoxLanguages.SelectedItem = "de";
            Assert.AreEqual("Hauptform", forma.Text, true);
            Assert.AreEqual("Sprache:", forma.labelLanguage.Text, true);
            Assert.AreEqual("Guten Tag!", forma.labelGreeting.Text, true);
        }
    }
}