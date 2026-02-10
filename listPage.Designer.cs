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
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
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
            label2.Location = new Point(198, 241);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Qualité";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 305);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Nom";
            // 
            // BOuvrir
            // 
            BOuvrir.Location = new Point(31, 241);
            BOuvrir.Name = "BOuvrir";
            BOuvrir.Size = new Size(94, 29);
            BOuvrir.TabIndex = 3;
            BOuvrir.Text = "Ouvrir";
            BOuvrir.UseVisualStyleBackColor = true;
            // 
            // BEnregistrer
            // 
            BEnregistrer.Location = new Point(31, 276);
            BEnregistrer.Name = "BEnregistrer";
            BEnregistrer.Size = new Size(94, 29);
            BEnregistrer.TabIndex = 4;
            BEnregistrer.Text = "Enregistrer";
            BEnregistrer.UseVisualStyleBackColor = true;
            // 
            // BAjouter
            // 
            BAjouter.Location = new Point(31, 348);
            BAjouter.Name = "BAjouter";
            BAjouter.Size = new Size(94, 29);
            BAjouter.TabIndex = 5;
            BAjouter.Text = "Ajouter";
            BAjouter.UseVisualStyleBackColor = true;
            // 
            // BSupprimer
            // 
            BSupprimer.Location = new Point(31, 383);
            BSupprimer.Name = "BSupprimer";
            BSupprimer.Size = new Size(94, 29);
            BSupprimer.TabIndex = 6;
            BSupprimer.Text = "Supprimer";
            BSupprimer.UseVisualStyleBackColor = true;
            // 
            // BConfirmer
            // 
            BConfirmer.Location = new Point(198, 372);
            BConfirmer.Name = "BConfirmer";
            BConfirmer.Size = new Size(94, 29);
            BConfirmer.TabIndex = 7;
            BConfirmer.Text = "Confirmer";
            BConfirmer.UseVisualStyleBackColor = true;
            // 
            // BAnnuler
            // 
            BAnnuler.Location = new Point(302, 372);
            BAnnuler.Name = "BAnnuler";
            BAnnuler.Size = new Size(94, 29);
            BAnnuler.TabIndex = 8;
            BAnnuler.Text = "Annuler";
            BAnnuler.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(31, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(400, 144);
            listBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Madame", "Monsieur" });
            comboBox1.Location = new Point(198, 264);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(181, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 196);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Détails personne";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 328);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // listPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 463);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}