using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // TODO:070 Pokrenuti program. Otvoriti u FileExploreru kazalo projekta te pogledati sadržaj podkazala bin\Debug
        // TODO:071 Omogućiti lokalizaciju dijaloga za različite jezike: otvoriti Form1 u Designeru te u prozoru Properties promijeniti svojstvo Localizable u true
        // TODO:072 U svojstvu Language izabrati Croatian te za svaku kontrolu (uključujući i zaglavlje glavne forme) promijeniti svojstvo Text tako da prikazuje prevedeni hrvatski tekst
        // TODO:073 Prevesti program i provjeriti kamo su se prevedeni resursi pohranili (tj. pogledati sadržaj potkazala bin\Debug)
        // TODO:074 Pokrenuti program i provjeriti mijenja li se tekst kontrola pri promjeni izbora u padajućoj listi na formi

        private void comboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(comboBoxLanguages.SelectedItem.ToString());
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            resources.ApplyResources(this, Text);
            foreach (Control control in Controls)
                resources.ApplyResources(control, control.Name);
        }
    }
}
