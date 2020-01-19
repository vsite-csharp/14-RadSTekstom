﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Vsite.CSharp.RadSTekstom
{
    public partial class LocalizedForm : Form
    {
        public LocalizedForm()
        {
            InitializeComponent();
        }

        //  Pokrenuti program. Otvoriti u File Exploreru kazalo projekta te pogledati sadržaj podkazala bin\Debug
        //  Omogućiti lokalizaciju dijaloga za različite jezike: otvoriti LocalizedForm u Designeru te u prozoru Properties za LocalizedForm promijeniti svojstvo "Localizable" u true
        //  U prozoru Properties za LocalizedForm svojstvo "Language" promijeniti "Croatian" te za svaku kontrolu (uključujući i zaglavlje glavne forme) prevesti svojstvo Text na hrvatski tekst:
        //  - naslov "Main Form" prevesti u "Glavna Forma"
        //  - "Language:" prevesti u "Jezik:"
        //  - "Hello!" prevesti u "Dobar dan!"
        //  Proširiti čvor LocalizedForm u SolutionExploreru i provjeriti koje su datoteke dodane te pogledati njihov sadržaj
        //  Provjeriti što se događa s tekstovima u LocalizedForm kada se svojstvo Language vrati na "Default"
        //  Buildati program i provjeriti kamo su se prevedeni resursi pohranili (tj. pogledati sadržaj potkazala bin\Debug)
        //  Pokrenuti program i provjeriti mijenja li se tekst kontrola pri promjeni izbora u padajućoj listi na formi
        //  U prozoru Properties za LocalizedForm promijeniti language na "German" te prevesti tekstove:
        //  - naslov "Main Form" prevesti u "Hauptform"
        //  - "Language:" prevesti u "Sprache:"
        //  - "Hello!" prevesti u "Guten Tag!"
        //  Pokrenuti program i provjeriti prikazuju li se njemački prijevodi ispravno 
        //  Pokrenuti testove (2 testa iz grupe "TestLokalizacijeDijaloga" moraju proći) 

        private void comboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(comboBoxLanguages.SelectedItem.ToString());
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizedForm));
            if (resources.GetString("$this.Text") != null)
                Text = resources.GetString("$this.Text");
            foreach (Control control in Controls)
                resources.ApplyResources(control, control.Name);
        }
    }
}
