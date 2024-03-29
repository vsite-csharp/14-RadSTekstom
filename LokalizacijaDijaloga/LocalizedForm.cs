﻿namespace Vsite.CSharp.RadSTekstom
{
    public partial class LocalizedForm : Form
    {
        public LocalizedForm()
        {
            InitializeComponent();
        }
        // TODO:070 Pokrenuti program. Otvoriti u File Exploreru kazalo projekta te pogledati sadržaj podkazala bin\Debug
        // TODO:071 Omogućiti lokalizaciju dijaloga za različite jezike: otvoriti LocalizedForm u Designeru te u prozoru Properties za LocalizedForm promijeniti svojstvo "Localizable" u true
        // TODO:072 U prozoru Properties za LocalizedForm svojstvo "Language" promijeniti "Croatian" te za svaku kontrolu (uključujući i zaglavlje glavne forme) prevesti svojstvo Text na hrvatski tekst:
        //  - naslov "Main Form" prevesti u "Glavna Forma"
        //  - "Language:" prevesti u "Jezik:"
        //  - "Hello!" prevesti u "Dobar dan!"
        // TODO:073 Proširiti čvor LocalizedForm u SolutionExploreru i provjeriti koje su datoteke dodane te pogledati njihov sadržaj
        // TODO:074 Provjeriti što se događa s tekstovima u LocalizedForm kada se svojstvo Language vrati na "Default"
        // TODO:075 Buildati program i provjeriti kamo su se prevedeni resursi pohranili (tj. pogledati sadržaj potkazala bin\Debug)
        // TODO:076 Pokrenuti program i provjeriti mijenja li se tekst kontrola pri promjeni izbora u padajućoj listi na formi
        // TODO:077 U prozoru Properties za LocalizedForm promijeniti language na "German" te prevesti tekstove:
        //  - naslov "Main Form" prevesti u "Hauptform"
        //  - "Language:" prevesti u "Sprache:"
        //  - "Hello!" prevesti u "Guten Tag!"
        // TODO:078 Pokrenuti program i provjeriti prikazuju li se njemački prijevodi ispravno 
        // TODO:079 Pokrenuti testove (2 testa iz grupe "TestLokalizacijeDijaloga" moraju proći) 

        private void comboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCulture = comboBoxLanguages.SelectedItem.ToString();
            if (selectedCulture != null)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(selectedCulture);
            }
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizedForm));
            if (resources.GetString("$this.Text") != null)
                Text = resources.GetString("$this.Text");
            foreach (Control control in Controls)
                resources.ApplyResources(control, control.Name);
        }
    }
}