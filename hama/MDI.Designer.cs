namespace hama
{
    partial class MDI
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnostiqueStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appelStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etablissementLink101ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gInterrogationGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lireSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.supprimerUnSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerTousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testReseauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.testModemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 516);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(997, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.diagnostiqueStationToolStripMenuItem,
            this.gestionSMSToolStripMenuItem,
            this.testToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newConfigToolStripMenuItem,
            this.defaultConfigToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "&Config";
            // 
            // newConfigToolStripMenuItem
            // 
            this.newConfigToolStripMenuItem.Name = "newConfigToolStripMenuItem";
            this.newConfigToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newConfigToolStripMenuItem.Text = "&New Config";
            // 
            // defaultConfigToolStripMenuItem
            // 
            this.defaultConfigToolStripMenuItem.Name = "defaultConfigToolStripMenuItem";
            this.defaultConfigToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.defaultConfigToolStripMenuItem.Text = "&Default Config";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // diagnostiqueStationToolStripMenuItem
            // 
            this.diagnostiqueStationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appelStationToolStripMenuItem,
            this.etablissementLink101ToolStripMenuItem,
            this.toolStripSeparator1,
            this.gInterrogationGeneralToolStripMenuItem});
            this.diagnostiqueStationToolStripMenuItem.Name = "diagnostiqueStationToolStripMenuItem";
            this.diagnostiqueStationToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.diagnostiqueStationToolStripMenuItem.Text = "Diagnostique &Station";
            // 
            // appelStationToolStripMenuItem
            // 
            this.appelStationToolStripMenuItem.Name = "appelStationToolStripMenuItem";
            this.appelStationToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.appelStationToolStripMenuItem.Text = "&Appel Station";
            // 
            // etablissementLink101ToolStripMenuItem
            // 
            this.etablissementLink101ToolStripMenuItem.Name = "etablissementLink101ToolStripMenuItem";
            this.etablissementLink101ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.etablissementLink101ToolStripMenuItem.Text = "&Etablissement Link 101";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // gInterrogationGeneralToolStripMenuItem
            // 
            this.gInterrogationGeneralToolStripMenuItem.Name = "gInterrogationGeneralToolStripMenuItem";
            this.gInterrogationGeneralToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.gInterrogationGeneralToolStripMenuItem.Text = "&G.Interrogation general";
            // 
            // gestionSMSToolStripMenuItem
            // 
            this.gestionSMSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lireSMSToolStripMenuItem,
            this.toolStripSeparator3,
            this.supprimerUnSMSToolStripMenuItem,
            this.supprimerTousToolStripMenuItem});
            this.gestionSMSToolStripMenuItem.Name = "gestionSMSToolStripMenuItem";
            this.gestionSMSToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.gestionSMSToolStripMenuItem.Text = "&Gestion SMS";
            // 
            // lireSMSToolStripMenuItem
            // 
            this.lireSMSToolStripMenuItem.Name = "lireSMSToolStripMenuItem";
            this.lireSMSToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.lireSMSToolStripMenuItem.Text = "&Lire SMS";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // supprimerUnSMSToolStripMenuItem
            // 
            this.supprimerUnSMSToolStripMenuItem.Name = "supprimerUnSMSToolStripMenuItem";
            this.supprimerUnSMSToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.supprimerUnSMSToolStripMenuItem.Text = "&Supprimer un SMS";
            // 
            // supprimerTousToolStripMenuItem
            // 
            this.supprimerTousToolStripMenuItem.Name = "supprimerTousToolStripMenuItem";
            this.supprimerTousToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.supprimerTousToolStripMenuItem.Text = "Supprimer &Tout SMS";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testReseauToolStripMenuItem,
            this.toolStripSeparator4,
            this.testModemToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "&Test";
            // 
            // testReseauToolStripMenuItem
            // 
            this.testReseauToolStripMenuItem.Name = "testReseauToolStripMenuItem";
            this.testReseauToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.testReseauToolStripMenuItem.Text = "Test &Reseau";
            this.testReseauToolStripMenuItem.Click += new System.EventHandler(this.testReseauToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(138, 6);
            // 
            // testModemToolStripMenuItem
            // 
            this.testModemToolStripMenuItem.Name = "testModemToolStripMenuItem";
            this.testModemToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.testModemToolStripMenuItem.Text = "Test &Modem";
            this.testModemToolStripMenuItem.Click += new System.EventHandler(this.testModemToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.aideToolStripMenuItem.Text = "&Aide ?";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 538);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDI";
            this.Text = "MDI";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnostiqueStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appelStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etablissementLink101ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gInterrogationGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lireSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerTousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testReseauToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem testModemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip;
    }
}



