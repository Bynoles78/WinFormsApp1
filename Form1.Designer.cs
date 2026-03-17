namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            MenuContrôle = new ToolStripMenuItem();
            MenuListe = new ToolStripMenuItem();
            MenubarreDeProgression = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MenuQuitter = new ToolStripMenuItem();
            MenuApplication = new ToolStripMenuItem();
            MenuEditer = new ToolStripMenuItem();
            ficSpiToolStripMenuItem = new ToolStripMenuItem();
            MenuAide = new ToolStripMenuItem();
            MenuAPropos = new ToolStripMenuItem();
            ecranClavierSourisToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuContrôle, MenuApplication, MenuAide });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(779, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuContrôle
            // 
            MenuContrôle.DropDownItems.AddRange(new ToolStripItem[] { MenuListe, MenubarreDeProgression, toolStripSeparator1, MenuQuitter });
            MenuContrôle.Name = "MenuContrôle";
            MenuContrôle.Size = new Size(86, 24);
            MenuContrôle.Text = "Contrôles";
            // 
            // MenuListe
            // 
            MenuListe.Name = "MenuListe";
            MenuListe.Size = new Size(230, 26);
            MenuListe.Text = "Liste";
            MenuListe.Click += MenuListe_click;
            // 
            // MenubarreDeProgression
            // 
            MenubarreDeProgression.Name = "MenubarreDeProgression";
            MenubarreDeProgression.Size = new Size(230, 26);
            MenubarreDeProgression.Text = "Barre de progression";
            MenubarreDeProgression.Click += MenubarreDeProgression_click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(227, 6);
            // 
            // MenuQuitter
            // 
            MenuQuitter.Name = "MenuQuitter";
            MenuQuitter.ShortcutKeyDisplayString = "Alt+Q";
            MenuQuitter.ShortcutKeys = Keys.Alt | Keys.Q;
            MenuQuitter.Size = new Size(230, 26);
            MenuQuitter.Text = "Quitter";
            MenuQuitter.Click += MenuQuitter_click;
            // 
            // MenuApplication
            // 
            MenuApplication.DropDownItems.AddRange(new ToolStripItem[] { MenuEditer, ficSpiToolStripMenuItem, ecranClavierSourisToolStripMenuItem });
            MenuApplication.Name = "MenuApplication";
            MenuApplication.Size = new Size(100, 24);
            MenuApplication.Text = "Application";
            // 
            // MenuEditer
            // 
            MenuEditer.Name = "MenuEditer";
            MenuEditer.Size = new Size(224, 26);
            MenuEditer.Text = "Editeur";
            MenuEditer.Click += MenuEditer_click;
            // 
            // ficSpiToolStripMenuItem
            // 
            ficSpiToolStripMenuItem.Name = "ficSpiToolStripMenuItem";
            ficSpiToolStripMenuItem.Size = new Size(224, 26);
            ficSpiToolStripMenuItem.Text = "Spirographe";
            ficSpiToolStripMenuItem.Click += ficSpiToolStripMenuItem_Click;
            // 
            // MenuAide
            // 
            MenuAide.DropDownItems.AddRange(new ToolStripItem[] { MenuAPropos });
            MenuAide.Name = "MenuAide";
            MenuAide.Size = new Size(54, 24);
            MenuAide.Text = "Aide";
            // 
            // MenuAPropos
            // 
            MenuAPropos.Name = "MenuAPropos";
            MenuAPropos.Size = new Size(152, 26);
            MenuAPropos.Text = "A Propos";
            MenuAPropos.Click += MenuAPropos_click;
            // 
            // ecranClavierSourisToolStripMenuItem
            // 
            ecranClavierSourisToolStripMenuItem.Name = "ecranClavierSourisToolStripMenuItem";
            ecranClavierSourisToolStripMenuItem.Size = new Size(224, 26);
            ecranClavierSourisToolStripMenuItem.Text = "EcranClavierSouris";
            ecranClavierSourisToolStripMenuItem.Click += ecranClavierSourisToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 336);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuContrôle;
        private ToolStripMenuItem MenuApplication;
        private ToolStripMenuItem MenuAide;
        private ToolStripMenuItem MenuListe;
        private ToolStripMenuItem MenubarreDeProgression;
        private ToolStripMenuItem MenuQuitter;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MenuEditer;
        private ToolStripMenuItem MenuAPropos;
        private ToolStripMenuItem ficSpiToolStripMenuItem;
        private ToolStripMenuItem ecranClavierSourisToolStripMenuItem;
    }
}
