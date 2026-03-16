namespace WinFormsApp1
{
    partial class FicSpirographe
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
            gbParametrage = new GroupBox();
            lSommets = new Label();
            lDensite = new Label();
            lProfondeur = new Label();
            tbSommets = new TrackBar();
            tbDensite = new TrackBar();
            tbProfondeur = new TrackBar();
            bGo = new Button();
            bTrait = new Button();
            bFond = new Button();
            cdCouleur = new ColorDialog();
            gbParametrage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbSommets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).BeginInit();
            SuspendLayout();

            // gbParametrage
            gbParametrage.Controls.Add(tbProfondeur);
            gbParametrage.Controls.Add(lProfondeur);
            gbParametrage.Controls.Add(tbDensite);
            gbParametrage.Controls.Add(lDensite);
            gbParametrage.Controls.Add(tbSommets);
            gbParametrage.Controls.Add(lSommets);
            gbParametrage.Controls.Add(bGo);
            gbParametrage.Controls.Add(bTrait);
            gbParametrage.Controls.Add(bFond);
            gbParametrage.Location = new Point(12, 12);
            gbParametrage.Name = "gbParametrage";
            gbParametrage.Size = new Size(220, 440);
            gbParametrage.TabIndex = 0;
            gbParametrage.TabStop = false;
            gbParametrage.Text = "Paramétrage";

            // lSommets
            lSommets.AutoSize = true;
            lSommets.Location = new Point(6, 25);
            lSommets.Name = "lSommets";
            lSommets.Size = new Size(72, 20);
            lSommets.TabIndex = 0;
            lSommets.Text = "Sommets: 3";

            // tbSommets
            tbSommets.Location = new Point(6, 48);
            tbSommets.Minimum = 3;
            tbSommets.Maximum = 8;
            tbSommets.Name = "tbSommets";
            tbSommets.Size = new Size(208, 56);
            tbSommets.TabIndex = 1;
            tbSommets.Value = 3;
            tbSommets.Scroll += TbSommets_Scroll;

            // lDensite
            lDensite.AutoSize = true;
            lDensite.Location = new Point(6, 100);
            lDensite.Name = "lDensite";
            lDensite.Size = new Size(66, 20);
            lDensite.TabIndex = 2;
            lDensite.Text = "Densité: 2";

            // tbDensite
            tbDensite.Location = new Point(6, 123);
            tbDensite.Minimum = 1;
            tbDensite.Maximum = 10;
            tbDensite.Name = "tbDensite";
            tbDensite.Size = new Size(208, 56);
            tbDensite.TabIndex = 3;
            tbDensite.Value = 2;
            tbDensite.Scroll += TbDensite_Scroll;

            // lProfondeur
            lProfondeur.AutoSize = true;
            lProfondeur.Location = new Point(6, 175);
            lProfondeur.Name = "lProfondeur";
            lProfondeur.Size = new Size(84, 20);
            lProfondeur.TabIndex = 4;
            lProfondeur.Text = "Profondeur: 50";

            // tbProfondeur
            tbProfondeur.Location = new Point(6, 198);
            tbProfondeur.Minimum = 10;
            tbProfondeur.Maximum = 100;
            tbProfondeur.Name = "tbProfondeur";
            tbProfondeur.Size = new Size(208, 56);
            tbProfondeur.TabIndex = 5;
            tbProfondeur.Value = 50;
            tbProfondeur.Scroll += TbProfondeur_Scroll;

            // bFond
            bFond.Location = new Point(6, 270);
            bFond.Name = "bFond";
            bFond.Size = new Size(208, 40);
            bFond.TabIndex = 6;
            bFond.Text = "Couleur fond";
            bFond.UseVisualStyleBackColor = true;
            bFond.Click += BFond_Click;

            // bTrait
            bTrait.Location = new Point(6, 316);
            bTrait.Name = "bTrait";
            bTrait.Size = new Size(208, 40);
            bTrait.TabIndex = 7;
            bTrait.Text = "Couleur trait";
            bTrait.UseVisualStyleBackColor = true;
            bTrait.Click += BTrait_Click;

            // bGo
            bGo.Location = new Point(6, 362);
            bGo.Name = "bGo";
            bGo.Size = new Size(208, 60);
            bGo.TabIndex = 8;
            bGo.Text = "Dessiner";
            bGo.UseVisualStyleBackColor = true;
            bGo.Click += BGo_Click;

            // FicSpirographe
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbParametrage);
            Name = "FicSpirographe";
            Text = "Spirographe";
            Load += FicSpirographe_Load;
            Paint += FicSpirographe_Paint;
            gbParametrage.ResumeLayout(false);
            gbParametrage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbSommets).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbParametrage;
        private Label lSommets;
        private Label lDensite;
        private Label lProfondeur;
        private TrackBar tbSommets;
        private TrackBar tbDensite;
        private TrackBar tbProfondeur;
        private Button bGo;
        private Button bTrait;
        private Button bFond;
        private ColorDialog cdCouleur;
    }
}