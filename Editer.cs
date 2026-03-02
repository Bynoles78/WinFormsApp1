using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Editer : Form
    {
        private string sFichier = "";
        private bool bModifier = false;

        public Editer()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            sFichier = "";
            bModifier = false;
            rtbTexte.TextChanged += RtbTexte_TextChanged;
            
            // Attacher les événements de clic des PictureBox
            pictureBox1.Click += pbNouveau_Click;
            pictureBox2.Click += pbOuvrir_Click;
            pictureBox3.Click += pbEnregistrer_Click;
            
            // Attacher les événements de clic du menu
            nouveauToolStripMenuItem.Click += pbNouveau_Click;
            ouvrirToolStripMenuItem.Click += pbOuvrir_Click;
            enregistrerToolStripMenuItem.Click += pbEnregistrer_Click;
            quitterToolStripMenuItem.Click += pbQuitter_Click;
            
            // Événements d'édition
            copierToolStripMenuItem.Click += Copier_Click;
            couperToolStripMenuItem.Click += Couper_Click;
            collerToolStripMenuItem.Click += Coller_Click;
            
            // Événements de formatage
            gaucheToolStripMenuItem.Click += Gauche_Click;
            centreToolStripMenuItem.Click += Centre_Click;
            droiteToolStripMenuItem.Click += Droite_Click;
            policeToolStripMenuItem.Click += Police_Click;
            
            // Événements de caractères
            grasToolStripMenuItem.Click += Gras_Click;
            italiqueToolStripMenuItem.Click += Italique_Click;
            soulignéToolStripMenuItem.Click += Souligne_Click;
            barréToolStripMenuItem.Click += Barre_Click;
        }

        private void RtbTexte_TextChanged(object sender, EventArgs e)
        {
            bModifier = true;
        }

        private void FichierEnregistrer()
        {
            if (string.IsNullOrEmpty(sFichier))
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sFichier = saveFileDialog1.FileName;
                    try
                    {
                        File.WriteAllText(sFichier, rtbTexte.Text);
                        bModifier = false;
                        MessageBox.Show("Fichier enregistré avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de l'enregistrement: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                try
                {
                    File.WriteAllText(sFichier, rtbTexte.Text);
                    bModifier = false;
                    MessageBox.Show("Fichier enregistré avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'enregistrement: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void VerifierSauver()
        {
            if (bModifier)
            {
                DialogResult result = MessageBox.Show("Voulez-vous enregistrer les modifications avant de continuer ?", "Modification détectée", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FichierEnregistrer();
                }
            }
        }

        private void pbNouveau_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            rtbTexte.Clear();
            sFichier = "";
            bModifier = false;
        }

        private void pbOuvrir_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sFichier = openFileDialog1.FileName;
                    rtbTexte.Text = File.ReadAllText(sFichier);
                    bModifier = false;
                    MessageBox.Show("Fichier ouvert avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'ouverture: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbEnregistrer_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            this.Close();
        }

        // Méthodes d'édition
        private void Copier_Click(object sender, EventArgs e)
        {
            rtbTexte.Copy();
        }

        private void Couper_Click(object sender, EventArgs e)
        {
            rtbTexte.Cut();
        }

        private void Coller_Click(object sender, EventArgs e)
        {
            rtbTexte.Paste();
        }

        // Méthodes de justification
        private void Gauche_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void Centre_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Droite_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Police_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbTexte.Font = fontDialog1.Font;
            }
        }

        // Méthodes de caractères
        private void Gras_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Bold);
            bModifier = true;
        }

        private void Italique_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Italic);
            bModifier = true;
        }

        private void Souligne_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Underline);
            bModifier = true;
        }

        private void Barre_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Strikeout);
            bModifier = true;
        }

        private void pMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
        }
    }
}
