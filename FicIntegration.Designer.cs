namespace WinFormsApp1
{
    partial class FicIntegration
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
            lGauche = new Label();
            tbGauche = new TextBox();
            tbDroite = new TextBox();
            lDroite = new Label();
            tbNbInt = new TextBox();
            lNbInt = new Label();
            lbResultats = new ListBox();
            bPolynome = new Button();
            bTrigonometrique = new Button();
            bPointeurPolynome = new Button();
            bPointeurTrigonometrique = new Button();
            SuspendLayout();
            // 
            // lGauche
            // 
            lGauche.AutoSize = true;
            lGauche.Location = new Point(12, 9);
            lGauche.Name = "lGauche";
            lGauche.Size = new Size(58, 20);
            lGauche.TabIndex = 0;
            lGauche.Text = "Gauche";
            // 
            // tbGauche
            // 
            tbGauche.Location = new Point(12, 32);
            tbGauche.Name = "tbGauche";
            tbGauche.Size = new Size(125, 27);
            tbGauche.TabIndex = 1;
            // 
            // tbDroite
            // 
            tbDroite.Location = new Point(143, 32);
            tbDroite.Name = "tbDroite";
            tbDroite.Size = new Size(125, 27);
            tbDroite.TabIndex = 3;
            // 
            // lDroite
            // 
            lDroite.AutoSize = true;
            lDroite.Location = new Point(143, 9);
            lDroite.Name = "lDroite";
            lDroite.Size = new Size(51, 20);
            lDroite.TabIndex = 2;
            lDroite.Text = "Droite";
            // 
            // tbNbInt
            // 
            tbNbInt.Location = new Point(274, 32);
            tbNbInt.Name = "tbNbInt";
            tbNbInt.Size = new Size(125, 27);
            tbNbInt.TabIndex = 5;
            // 
            // lNbInt
            // 
            lNbInt.AutoSize = true;
            lNbInt.Location = new Point(274, 9);
            lNbInt.Name = "lNbInt";
            lNbInt.Size = new Size(147, 20);
            lNbInt.TabIndex = 4;
            lNbInt.Text = "Nombre d'Intervalles";
            // 
            // lbResultats
            // 
            lbResultats.FormattingEnabled = true;
            lbResultats.Location = new Point(12, 65);
            lbResultats.Name = "lbResultats";
            lbResultats.Size = new Size(387, 224);
            lbResultats.TabIndex = 6;
            // 
            // bPolynome
            // 
            bPolynome.Location = new Point(12, 301);
            bPolynome.Name = "bPolynome";
            bPolynome.Size = new Size(232, 46);
            bPolynome.TabIndex = 7;
            bPolynome.Text = "Polynôme : x*x +2";
            bPolynome.UseVisualStyleBackColor = true;
            bPolynome.Click += bPolynome_Click;
            // 
            // bTrigonometrique
            // 
            bTrigonometrique.Location = new Point(12, 353);
            bTrigonometrique.Name = "bTrigonometrique";
            bTrigonometrique.Size = new Size(232, 42);
            bTrigonometrique.TabIndex = 8;
            bTrigonometrique.Text = "Trigonométrique : sin(x)";
            bTrigonometrique.UseVisualStyleBackColor = true;
            bTrigonometrique.Click += bTrigonometrique_Click;
            // 
            // bPointeurPolynome
            // 
            bPointeurPolynome.Location = new Point(250, 301);
            bPointeurPolynome.Name = "bPointeurPolynome";
            bPointeurPolynome.Size = new Size(149, 46);
            bPointeurPolynome.TabIndex = 9;
            bPointeurPolynome.Text = "Idem Pointeur";
            bPointeurPolynome.UseVisualStyleBackColor = true;
            bPointeurPolynome.Click += bPointeurPolynome_Click;
            // 
            // bPointeurTrigonometrique
            // 
            bPointeurTrigonometrique.Location = new Point(250, 353);
            bPointeurTrigonometrique.Name = "bPointeurTrigonometrique";
            bPointeurTrigonometrique.Size = new Size(149, 42);
            bPointeurTrigonometrique.TabIndex = 10;
            bPointeurTrigonometrique.Text = "Idem Pointeur";
            bPointeurTrigonometrique.UseVisualStyleBackColor = true;
            bPointeurTrigonometrique.Click += bPointeurTrigonometrique_Click;
            // 
            // FicIntegration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 409);
            Controls.Add(bPointeurTrigonometrique);
            Controls.Add(bPointeurPolynome);
            Controls.Add(bTrigonometrique);
            Controls.Add(bPolynome);
            Controls.Add(lbResultats);
            Controls.Add(tbNbInt);
            Controls.Add(lNbInt);
            Controls.Add(tbDroite);
            Controls.Add(lDroite);
            Controls.Add(tbGauche);
            Controls.Add(lGauche);
            Name = "FicIntegration";
            Text = "Integration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lGauche;
        private TextBox tbGauche;
        private TextBox tbDroite;
        private Label lDroite;
        private TextBox tbNbInt;
        private Label lNbInt;
        private ListBox lbResultats;
        private Button bPolynome;
        private Button bTrigonometrique;
        private Button bPointeurPolynome;
        private Button bPointeurTrigonometrique;
    }
}