using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class listPage : Form
    {
        private string NomFichier = "";

        public listPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Activer(false);
            cboQualite.SelectedIndex = -1;
        }

        private void Activer(bool accessible)
        {
            lbPersonne.Enabled = accessible;
            BAjouter.Enabled = accessible;
            BSupprimer.Enabled = accessible;
            BOuvrir.Enabled = accessible;
            BEnregistrer.Enabled = accessible;

            groupBox1.Enabled = !accessible;
            BConfirmer.Enabled = !accessible;
            BAnnuler.Enabled = !accessible;
        }

        private void BAjouter_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtNom.Enabled = true;
            cboQualite.Enabled = true;
            BConfirmer.Enabled = true;
            BAnnuler.Enabled = true;

            lbPersonne.Enabled = false;
            BAjouter.Enabled = false;
            BSupprimer.Enabled = false;
            BOuvrir.Enabled = false;
            BEnregistrer.Enabled = false;
        }

        private void BSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                lbPersonne.Items.RemoveAt(lbPersonne.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BConfirmer_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string qualite = cboQualite.SelectedItem?.ToString() ?? "";

            if (!string.IsNullOrEmpty(nom) && !string.IsNullOrEmpty(qualite))
            {
                lbPersonne.Items.Add($"{nom} ({qualite})");
                txtNom.Clear();
                cboQualite.SelectedIndex = -1;

                lbPersonne.Enabled = true;
                BAjouter.Enabled = true;
                BSupprimer.Enabled = true;
                BOuvrir.Enabled = true;
                BEnregistrer.Enabled = true;

                groupBox1.Enabled = false;
                BConfirmer.Enabled = false;
                BAnnuler.Enabled = false;
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BAnnuler_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            cboQualite.SelectedIndex = -1;

            lbPersonne.Enabled = true;
            BAjouter.Enabled = true;
            BSupprimer.Enabled = true;
            BOuvrir.Enabled = true;
            BEnregistrer.Enabled = true;

            groupBox1.Enabled = false;
            BConfirmer.Enabled = false;
            BAnnuler.Enabled = false;
        }

        private void BOuvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdOuvrirFichier = new OpenFileDialog();
            ofdOuvrirFichier.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            ofdOuvrirFichier.Title = "Ouvrir un fichier";

            if (ofdOuvrirFichier.ShowDialog() == DialogResult.OK)
            {
                NomFichier = ofdOuvrirFichier.FileName;
                lbPersonne.Items.Clear();

                try
                {
                    string[] lignes = File.ReadAllLines(NomFichier);
                    foreach (string ligne in lignes)
                    {
                        if (!string.IsNullOrEmpty(ligne))
                        {
                            lbPersonne.Items.Add(ligne);
                        }
                    }
                    MessageBox.Show("Fichier ouvert avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'ouverture du fichier: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BEnregistrer_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdEnregistrer = new SaveFileDialog();
            sfdEnregistrer.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            sfdEnregistrer.Title = "Enregistrer un fichier";

            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                NomFichier = sfdEnregistrer.FileName;

                try
                {
                    List<string> lignes = new List<string>();
                    foreach (var item in lbPersonne.Items)
                    {
                        lignes.Add(item.ToString());
                    }
                    File.WriteAllLines(NomFichier, lignes);
                    MessageBox.Show("Fichier enregistré avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'enregistrement du fichier: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbPersonne_DoubleClick(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                string item = lbPersonne.SelectedItem.ToString();
                int index = lbPersonne.SelectedIndex;
                MessageBox.Show($"Données: {item}\nNuméro de ligne (index): {index}", "Détails", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
