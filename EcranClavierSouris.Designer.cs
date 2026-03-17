namespace WinFormsApp1
{
    partial class EcranClavierSouris
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
            pnlSouris = new Panel();
            lblClavier = new Label();
            lblClicGauche = new Label();
            lblClicDroit = new Label();
            lblPositionX = new Label();
            lblPositionY = new Label();
            lsbClavier = new ListBox();
            butRAZ = new Button();
            tbxClicGauche = new TextBox();
            tbxClicDroit = new TextBox();
            tbxPositionX = new TextBox();
            tbxPositionY = new TextBox();
            SuspendLayout();
            // 
            // pnlSouris
            // 
            pnlSouris.BackColor = Color.LightGray;
            pnlSouris.BorderStyle = BorderStyle.FixedSingle;
            pnlSouris.Location = new Point(291, 65);
            pnlSouris.Name = "pnlSouris";
            pnlSouris.Size = new Size(497, 345);
            pnlSouris.TabIndex = 0;
            pnlSouris.Paint += PnlSouris_Paint;
            pnlSouris.MouseDown += PnlSouris_MouseDown;
            pnlSouris.MouseMove += PnlSouris_MouseMove;
            // 
            // lblClavier
            // 
            lblClavier.AutoSize = true;
            lblClavier.Location = new Point(12, 9);
            lblClavier.Name = "lblClavier";
            lblClavier.Size = new Size(136, 20);
            lblClavier.TabIndex = 1;
            lblClavier.Text = "Interception clavier";
            // 
            // lblClicGauche
            // 
            lblClicGauche.AutoSize = true;
            lblClicGauche.Location = new Point(291, 9);
            lblClicGauche.Name = "lblClicGauche";
            lblClicGauche.Size = new Size(85, 20);
            lblClicGauche.TabIndex = 4;
            lblClicGauche.Text = "Clic gauche";
            // 
            // lblClicDroit
            // 
            lblClicDroit.AutoSize = true;
            lblClicDroit.Location = new Point(382, 9);
            lblClicDroit.Name = "lblClicDroit";
            lblClicDroit.Size = new Size(69, 20);
            lblClicDroit.TabIndex = 6;
            lblClicDroit.Text = "Clic droit";
            // 
            // lblPositionX
            // 
            lblPositionX.AutoSize = true;
            lblPositionX.Location = new Point(473, 9);
            lblPositionX.Name = "lblPositionX";
            lblPositionX.Size = new Size(74, 20);
            lblPositionX.TabIndex = 8;
            lblPositionX.Text = "Position X";
            // 
            // lblPositionY
            // 
            lblPositionY.AutoSize = true;
            lblPositionY.Location = new Point(564, 9);
            lblPositionY.Name = "lblPositionY";
            lblPositionY.Size = new Size(73, 20);
            lblPositionY.TabIndex = 10;
            lblPositionY.Text = "Position Y";
            // 
            // lsbClavier
            // 
            lsbClavier.FormattingEnabled = true;
            lsbClavier.Location = new Point(12, 32);
            lsbClavier.Name = "lsbClavier";
            lsbClavier.Size = new Size(273, 324);
            lsbClavier.TabIndex = 2;
            // 
            // butRAZ
            // 
            butRAZ.Location = new Point(12, 370);
            butRAZ.Name = "butRAZ";
            butRAZ.Size = new Size(273, 40);
            butRAZ.TabIndex = 3;
            butRAZ.Text = "Remise à zéro";
            butRAZ.UseVisualStyleBackColor = true;
            butRAZ.Click += ButRAZ_Click;
            // 
            // tbxClicGauche
            // 
            tbxClicGauche.Location = new Point(291, 32);
            tbxClicGauche.Name = "tbxClicGauche";
            tbxClicGauche.ReadOnly = true;
            tbxClicGauche.Size = new Size(85, 27);
            tbxClicGauche.TabIndex = 5;
            tbxClicGauche.Text = "0";
            tbxClicGauche.TextAlign = HorizontalAlignment.Right;
            // 
            // tbxClicDroit
            // 
            tbxClicDroit.Location = new Point(382, 32);
            tbxClicDroit.Name = "tbxClicDroit";
            tbxClicDroit.ReadOnly = true;
            tbxClicDroit.Size = new Size(85, 27);
            tbxClicDroit.TabIndex = 7;
            tbxClicDroit.Text = "0";
            tbxClicDroit.TextAlign = HorizontalAlignment.Right;
            // 
            // tbxPositionX
            // 
            tbxPositionX.Location = new Point(473, 32);
            tbxPositionX.Name = "tbxPositionX";
            tbxPositionX.ReadOnly = true;
            tbxPositionX.Size = new Size(85, 27);
            tbxPositionX.TabIndex = 9;
            tbxPositionX.Text = "0";
            tbxPositionX.TextAlign = HorizontalAlignment.Right;
            // 
            // tbxPositionY
            // 
            tbxPositionY.Location = new Point(564, 32);
            tbxPositionY.Name = "tbxPositionY";
            tbxPositionY.ReadOnly = true;
            tbxPositionY.Size = new Size(85, 27);
            tbxPositionY.TabIndex = 11;
            tbxPositionY.Text = "0";
            tbxPositionY.TextAlign = HorizontalAlignment.Right;
            // 
            // EcranClavierSouris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(tbxPositionY);
            Controls.Add(lblPositionY);
            Controls.Add(tbxPositionX);
            Controls.Add(lblPositionX);
            Controls.Add(tbxClicDroit);
            Controls.Add(lblClicDroit);
            Controls.Add(tbxClicGauche);
            Controls.Add(lblClicGauche);
            Controls.Add(butRAZ);
            Controls.Add(lsbClavier);
            Controls.Add(lblClavier);
            Controls.Add(pnlSouris);
            KeyPreview = true;
            Name = "EcranClavierSouris";
            Text = "Espionnage du clavier et de la souris";
            Load += EcranClavierSouris_Load;
            KeyPress += EcranClavierSouris_KeyPress;
            //KeyDown += EcranClavierSouris_KeyDown;
            //KeyUp += EcranClavierSouris_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSouris;
        private Label lblClavier;
        private Label lblClicGauche;
        private Label lblClicDroit;
        private Label lblPositionX;
        private Label lblPositionY;
        private ListBox lsbClavier;
        private Button butRAZ;
        private TextBox tbxClicGauche;
        private TextBox tbxClicDroit;
        private TextBox tbxPositionX;
        private TextBox tbxPositionY;
    }
}