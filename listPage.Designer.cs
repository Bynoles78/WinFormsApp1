namespace WinFormsApp2
{
    partial class listPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BOuvrir = new Button();
            BEnregistrer = new Button();
            BAjouter = new Button();
            BSupprimer = new Button();
            BConfirmer = new Button();
            BAnnuler = new Button();
            lbPersonne = new ListBox();
            cboQualite = new ComboBox();
            groupBox1 = new GroupBox();
            txtNom = new TextBox();
            BModifier = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom de ficher";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(198, 241);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Qualité";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(198, 305);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Nom";
            // 
            // BOuvrir
            // 
            BOuvrir.Location = new Point(31, 232);
            BOuvrir.Name = "BOuvrir";
            BOuvrir.Size = new Size(94, 29);
            BOuvrir.TabIndex = 3;
            BOuvrir.Text = "Ouvrir";
            BOuvrir.UseVisualStyleBackColor = true;
            BOuvrir.Click += BOuvrir_Click;
            // 
            // BEnregistrer
            // 
            BEnregistrer.Location = new Point(31, 267);
            BEnregistrer.Name = "BEnregistrer";
            BEnregistrer.Size = new Size(94, 29);
            BEnregistrer.TabIndex = 4;
            BEnregistrer.Text = "Enregistrer";
            BEnregistrer.UseVisualStyleBackColor = true;
            BEnregistrer.Click += BEnregistrer_Click;
            // 
            // BAjouter
            // 
            BAjouter.Location = new Point(31, 313);
            BAjouter.Name = "BAjouter";
            BAjouter.Size = new Size(94, 29);
            BAjouter.TabIndex = 5;
            BAjouter.Text = "Ajouter";
            BAjouter.UseVisualStyleBackColor = true;
            BAjouter.Click += BAjouter_Click;
            // 
            // BSupprimer
            // 
            BSupprimer.Location = new Point(31, 383);
            BSupprimer.Name = "BSupprimer";
            BSupprimer.Size = new Size(94, 29);
            BSupprimer.TabIndex = 6;
            BSupprimer.Text = "Supprimer";
            BSupprimer.UseVisualStyleBackColor = true;
            BSupprimer.Click += BSupprimer_Click;
            // 
            // BConfirmer
            // 
            BConfirmer.Enabled = false;
            BConfirmer.Location = new Point(198, 372);
            BConfirmer.Name = "BConfirmer";
            BConfirmer.Size = new Size(94, 29);
            BConfirmer.TabIndex = 7;
            BConfirmer.Text = "Confirmer";
            BConfirmer.UseVisualStyleBackColor = true;
            BConfirmer.Click += BConfirmer_Click;
            // 
            // BAnnuler
            // 
            BAnnuler.Enabled = false;
            BAnnuler.Location = new Point(302, 372);
            BAnnuler.Name = "BAnnuler";
            BAnnuler.Size = new Size(94, 29);
            BAnnuler.TabIndex = 8;
            BAnnuler.Text = "Annuler";
            BAnnuler.UseVisualStyleBackColor = true;
            BAnnuler.Click += BAnnuler_Click;
            // 
            // lbPersonne
            // 
            lbPersonne.FormattingEnabled = true;
            lbPersonne.Location = new Point(31, 48);
            lbPersonne.Name = "lbPersonne";
            lbPersonne.Size = new Size(400, 144);
            lbPersonne.TabIndex = 9;
            // 
            // cboQualite
            // 
            cboQualite.Enabled = false;
            cboQualite.FormattingEnabled = true;
            cboQualite.Items.AddRange(new object[] { "Madame", "Monsieur" });
            cboQualite.Location = new Point(198, 264);
            cboQualite.Name = "cboQualite";
            cboQualite.Size = new Size(151, 28);
            cboQualite.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(181, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 196);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Détails personne";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtNom
            // 
            txtNom.Enabled = false;
            txtNom.Location = new Point(198, 328);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 0;
            // 
            // BModifier
            // 
            BModifier.Location = new Point(31, 348);
            BModifier.Name = "BModifier";
            BModifier.Size = new Size(94, 29);
            BModifier.TabIndex = 12;
            BModifier.Text = "Modifier";
            BModifier.UseVisualStyleBackColor = true;
            BModifier.Click += BModifier_Click;
            // 
            // listPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 463);
            Controls.Add(BModifier);
            Controls.Add(txtNom);
            Controls.Add(cboQualite);
            Controls.Add(lbPersonne);
            Controls.Add(BAnnuler);
            Controls.Add(BConfirmer);
            Controls.Add(BSupprimer);
            Controls.Add(BAjouter);
            Controls.Add(BEnregistrer);
            Controls.Add(BOuvrir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "listPage";
            Text = "list";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button BOuvrir;
        private Button BEnregistrer;
        private Button BAjouter;
        private Button BSupprimer;
        private Button BConfirmer;
        private Button BAnnuler;
        private ListBox lbPersonne;
        private ComboBox cboQualite;
        private GroupBox groupBox1;
        private TextBox txtNom;
        private Button BModifier;
    }
}