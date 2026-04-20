namespace WinFormsApp1
{
    partial class FicHistogramme
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
            bCreer = new Button();
            bDessiner = new Button();
            pDessin = new Panel();
            lbMonPoint = new ListBox();
            SuspendLayout();
            // 
            // bCreer
            // 
            bCreer.Location = new Point(216, 94);
            bCreer.Name = "bCreer";
            bCreer.Size = new Size(94, 29);
            bCreer.TabIndex = 0;
            bCreer.Text = "Créer";
            bCreer.UseVisualStyleBackColor = true;
            bCreer.Click += bCreer_Click;
            // 
            // bDessiner
            // 
            bDessiner.Location = new Point(385, 94);
            bDessiner.Name = "bDessiner";
            bDessiner.Size = new Size(94, 29);
            bDessiner.TabIndex = 1;
            bDessiner.Text = "Dessiner";
            bDessiner.UseVisualStyleBackColor = true;
            bDessiner.Click += bDessiner_Click;
            // 
            // pDessin
            // 
            pDessin.Location = new Point(316, 129);
            pDessin.Name = "pDessin";
            pDessin.Size = new Size(250, 184);
            pDessin.TabIndex = 2;
            pDessin.Paint += pDessin_Paint;
            // 
            // lbMonPoint
            // 
            lbMonPoint.FormattingEnabled = true;
            lbMonPoint.Location = new Point(216, 129);
            lbMonPoint.Name = "lbMonPoint";
            lbMonPoint.Size = new Size(94, 184);
            lbMonPoint.TabIndex = 3;
            // 
            // FicHistogramme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbMonPoint);
            Controls.Add(pDessin);
            Controls.Add(bDessiner);
            Controls.Add(bCreer);
            Name = "FicHistogramme";
            Text = "Histogramme";
            Load += FicHistogramme_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bCreer;
        private Button bDessiner;
        private Panel pDessin;
        private ListBox lbMonPoint;
    }
}