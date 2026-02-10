namespace WinFormsApp1
{
    partial class barreDeProgression
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
            button1 = new Button();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(71, 37);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Index pricipale";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(71, 115);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 1;
            label2.Text = "Index secondaire";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(44, 214);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Exécuter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(185, 214);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Quitter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(71, 70);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(174, 29);
            progressBar1.TabIndex = 4;
            
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(71, 149);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(174, 29);
            progressBar2.TabIndex = 5;
           
            // 
            // barreDeProgression
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 298);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "barreDeProgression";
            Text = "barreDeProgression";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
    }
}