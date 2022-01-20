namespace Vsite.CSharp.RadSTekstom
{
    partial class LocalizedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizedForm));
            this.labelLanguage = new System.Windows.Forms.Label();
            this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLanguage
            // 
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.Name = "labelLanguage";
            // 
            // comboBoxLanguages
            // 
            resources.ApplyResources(this.comboBoxLanguages, "comboBoxLanguages");
            this.comboBoxLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguages.FormattingEnabled = true;
            this.comboBoxLanguages.Items.AddRange(new object[] {
            resources.GetString("comboBoxLanguages.Items"),
            resources.GetString("comboBoxLanguages.Items1"),
            resources.GetString("comboBoxLanguages.Items2")});
            this.comboBoxLanguages.Name = "comboBoxLanguages";
            this.comboBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguages_SelectedIndexChanged);
            // 
            // labelGreeting
            // 
            resources.ApplyResources(this.labelGreeting, "labelGreeting");
            this.labelGreeting.Name = "labelGreeting";
            // 
            // LocalizedForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelGreeting);
            this.Controls.Add(this.comboBoxLanguages);
            this.Controls.Add(this.labelLanguage);
            this.Name = "LocalizedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBoxLanguages;
        public System.Windows.Forms.Label labelLanguage;
        public System.Windows.Forms.Label labelGreeting;
    }
}

