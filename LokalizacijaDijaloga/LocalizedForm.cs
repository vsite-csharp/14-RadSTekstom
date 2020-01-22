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
    public partial class LocalizedForm : Form
    {
        public LocalizedForm()
        {
            InitializeComponent();
        }


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
