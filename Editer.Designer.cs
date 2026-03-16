namespace WinFormsApp1
{
    partial class Editer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editer));
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            nouveauToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            enregistrerToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            editerToolStripMenuItem = new ToolStripMenuItem();
            copierToolStripMenuItem = new ToolStripMenuItem();
            couperToolStripMenuItem = new ToolStripMenuItem();
            collerToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            justifierToolStripMenuItem = new ToolStripMenuItem();
            gaucheToolStripMenuItem = new ToolStripMenuItem();
            centreToolStripMenuItem = new ToolStripMenuItem();
            droiteToolStripMenuItem = new ToolStripMenuItem();
            policeToolStripMenuItem = new ToolStripMenuItem();
            caractèreToolStripMenuItem = new ToolStripMenuItem();
            grasToolStripMenuItem = new ToolStripMenuItem();
            italiqueToolStripMenuItem = new ToolStripMenuItem();
            soulignéToolStripMenuItem = new ToolStripMenuItem();
            barréToolStripMenuItem = new ToolStripMenuItem();
            pMenu = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pbQuitter = new PictureBox();
            pictureBox1 = new PictureBox();
            rtbTexte = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, editerToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouveauToolStripMenuItem, ouvrirToolStripMenuItem, enregistrerToolStripMenuItem, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(66, 24);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            nouveauToolStripMenuItem.Size = new Size(163, 26);
            nouveauToolStripMenuItem.Text = "Nouveau";
            nouveauToolStripMenuItem.Click += pbNouveau_Click;
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(163, 26);
            ouvrirToolStripMenuItem.Text = "Ouvrir";
            ouvrirToolStripMenuItem.Click += pbOuvrir_Click;
            // 
            // enregistrerToolStripMenuItem
            // 
            enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            enregistrerToolStripMenuItem.Size = new Size(163, 26);
            enregistrerToolStripMenuItem.Text = "Enregistrer";
            enregistrerToolStripMenuItem.Click += pbEnregistrer_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(163, 26);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += pbQuitter_Click;
            // 
            // editerToolStripMenuItem
            // 
            editerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copierToolStripMenuItem, couperToolStripMenuItem, collerToolStripMenuItem });
            editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            editerToolStripMenuItem.Size = new Size(62, 24);
            editerToolStripMenuItem.Text = "Editer";
            // 
            // copierToolStripMenuItem
            // 
            copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            copierToolStripMenuItem.Size = new Size(140, 26);
            copierToolStripMenuItem.Text = "Copier";
            copierToolStripMenuItem.Click += Copier_Click;
            // 
            // couperToolStripMenuItem
            // 
            couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            couperToolStripMenuItem.Size = new Size(140, 26);
            couperToolStripMenuItem.Text = "Couper";
            couperToolStripMenuItem.Click += Couper_Click;
            // 
            // collerToolStripMenuItem
            // 
            collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            collerToolStripMenuItem.Size = new Size(140, 26);
            collerToolStripMenuItem.Text = "Coller";
            collerToolStripMenuItem.Click += Coller_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { justifierToolStripMenuItem, policeToolStripMenuItem, caractèreToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(70, 24);
            formatToolStripMenuItem.Text = "Format";
            // 
            // justifierToolStripMenuItem
            // 
            justifierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gaucheToolStripMenuItem, centreToolStripMenuItem, droiteToolStripMenuItem });
            justifierToolStripMenuItem.Name = "justifierToolStripMenuItem";
            justifierToolStripMenuItem.Size = new Size(155, 26);
            justifierToolStripMenuItem.Text = "Justifier";
            // 
            // gaucheToolStripMenuItem
            // 
            gaucheToolStripMenuItem.Name = "gaucheToolStripMenuItem";
            gaucheToolStripMenuItem.Size = new Size(141, 26);
            gaucheToolStripMenuItem.Text = "Gauche";
            gaucheToolStripMenuItem.Click += Gauche_Click;
            // 
            // centreToolStripMenuItem
            // 
            centreToolStripMenuItem.Name = "centreToolStripMenuItem";
            centreToolStripMenuItem.Size = new Size(141, 26);
            centreToolStripMenuItem.Text = "Centre";
            centreToolStripMenuItem.Click += Centre_Click;
            // 
            // droiteToolStripMenuItem
            // 
            droiteToolStripMenuItem.Name = "droiteToolStripMenuItem";
            droiteToolStripMenuItem.Size = new Size(141, 26);
            droiteToolStripMenuItem.Text = "Droite";
            droiteToolStripMenuItem.Click += Droite_Click;
            // 
            // policeToolStripMenuItem
            // 
            policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            policeToolStripMenuItem.Size = new Size(155, 26);
            policeToolStripMenuItem.Text = "Police";
            policeToolStripMenuItem.Click += Police_Click;
            // 
            // caractèreToolStripMenuItem
            // 
            caractèreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grasToolStripMenuItem, italiqueToolStripMenuItem, soulignéToolStripMenuItem, barréToolStripMenuItem });
            caractèreToolStripMenuItem.Name = "caractèreToolStripMenuItem";
            caractèreToolStripMenuItem.Size = new Size(155, 26);
            caractèreToolStripMenuItem.Text = "Caractère";
            // 
            // grasToolStripMenuItem
            // 
            grasToolStripMenuItem.Name = "grasToolStripMenuItem";
            grasToolStripMenuItem.Size = new Size(150, 26);
            grasToolStripMenuItem.Text = "Gras";
            grasToolStripMenuItem.Click += Gras_Click;
            // 
            // italiqueToolStripMenuItem
            // 
            italiqueToolStripMenuItem.Name = "italiqueToolStripMenuItem";
            italiqueToolStripMenuItem.Size = new Size(150, 26);
            italiqueToolStripMenuItem.Text = "Italique";
            italiqueToolStripMenuItem.Click += Italique_Click;
            // 
            // soulignéToolStripMenuItem
            // 
            soulignéToolStripMenuItem.Name = "soulignéToolStripMenuItem";
            soulignéToolStripMenuItem.Size = new Size(150, 26);
            soulignéToolStripMenuItem.Text = "Souligné";
            soulignéToolStripMenuItem.Click += Souligne_Click;
            // 
            // barréToolStripMenuItem
            // 
            barréToolStripMenuItem.Name = "barréToolStripMenuItem";
            barréToolStripMenuItem.Size = new Size(150, 26);
            barréToolStripMenuItem.Text = "Barré";
            barréToolStripMenuItem.Click += Barre_Click;
            // 
            // pMenu
            // 
            pMenu.BackColor = SystemColors.ControlLight;
            pMenu.Controls.Add(pictureBox3);
            pMenu.Controls.Add(pictureBox2);
            pMenu.Controls.Add(pbQuitter);
            pMenu.Controls.Add(pictureBox1);
            pMenu.Dock = DockStyle.Top;
            pMenu.Location = new Point(0, 28);
            pMenu.Name = "pMenu";
            pMenu.RightToLeft = RightToLeft.Yes;
            pMenu.Size = new Size(800, 32);
            pMenu.TabIndex = 5;
            pMenu.Paint += pMenu_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.sauvegarder;
            pictureBox3.Location = new Point(65, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pbEnregistrer_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Ouvrir;
            pictureBox2.Location = new Point(34, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pbOuvrir_Click;
            // 
            // pbQuitter
            // 
            pbQuitter.Image = (Image)resources.GetObject("pbQuitter.Image");
            pbQuitter.Location = new Point(96, 3);
            pbQuitter.Name = "pbQuitter";
            pbQuitter.Size = new Size(25, 25);
            pbQuitter.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitter.TabIndex = 6;
            pbQuitter.TabStop = false;
            pbQuitter.Click += pbQuitter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Nouveau;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pbNouveau_Click;
            // 
            // rtbTexte
            // 
            rtbTexte.Dock = DockStyle.Fill;
            rtbTexte.Font = new Font("Hack Nerd Font", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbTexte.Location = new Point(0, 60);
            rtbTexte.Name = "rtbTexte";
            rtbTexte.Size = new Size(800, 390);
            rtbTexte.TabIndex = 6;
            rtbTexte.Text = "";
            rtbTexte.TextChanged += RtbTexte_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // fontDialog1
            // 
            fontDialog1.Apply += fontDialog1_Apply;
            // 
            // Editer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbTexte);
            Controls.Add(pMenu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Editer";
            Text = "Editeur de texte (modeste)";
            Load += Form_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripMenuItem enregistrerToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem editerToolStripMenuItem;
        private ToolStripMenuItem copierToolStripMenuItem;
        private ToolStripMenuItem couperToolStripMenuItem;
        private ToolStripMenuItem collerToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem justifierToolStripMenuItem;
        private ToolStripMenuItem gaucheToolStripMenuItem;
        private ToolStripMenuItem centreToolStripMenuItem;
        private ToolStripMenuItem droiteToolStripMenuItem;
        private ToolStripMenuItem policeToolStripMenuItem;
        private ToolStripMenuItem caractèreToolStripMenuItem;
        private ToolStripMenuItem grasToolStripMenuItem;
        private ToolStripMenuItem italiqueToolStripMenuItem;
        private ToolStripMenuItem soulignéToolStripMenuItem;
        private ToolStripMenuItem barréToolStripMenuItem;
        private Panel pMenu;
        private PictureBox pbQuitter;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private RichTextBox rtbTexte;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
    }
}