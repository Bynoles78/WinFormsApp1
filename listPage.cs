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
        private int indexModification = -1;
        private List<int> listeNumeroEncodage = new List<int>();
        private int prochainNumeroEncodage = 1;

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
            BModifier.Enabled = accessible;

            groupBox1.Enabled = !accessible;
            BConfirmer.Enabled = !accessible;
            BAnnuler.Enabled = !accessible;
        }

        private void BAjouter_Click(object sender, EventArgs e)
        {
            indexModification = -1;
            groupBox1.Enabled = true;
            txtNom.Enabled = true;
            cboQualite.Enabled = true;
            BConfirmer.Enabled = true;
            BAnnuler.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;

            lbPersonne.Enabled = false;
            BAjouter.Enabled = false;
            BSupprimer.Enabled = false;
            BOuvrir.Enabled = false;
            BEnregistrer.Enabled = false;
            BModifier.Enabled = false;

            txtNom.Clear();
            cboQualite.SelectedIndex = -1;
        }

        private void BModifier_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                indexModification = lbPersonne.SelectedIndex;
                string item = lbPersonne.SelectedItem.ToString();

                // Extraire le nom et la qualité
                int indexParenthese = item.LastIndexOf('(');
                if (indexParenthese > 0)
                {
                    string nom = item.Substring(0, indexParenthese).Trim();
                    string qualite = item.Substring(indexParenthese + 1, item.Length - indexParenthese - 2).Trim();

                    txtNom.Text = nom;
                    cboQualite.SelectedItem = qualite;
                }

                groupBox1.Enabled = true;
                txtNom.Enabled = true;
                cboQualite.Enabled = true;
                BConfirmer.Enabled = true;
                BAnnuler.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;

                lbPersonne.Enabled = false;
                BAjouter.Enabled = false;
                BSupprimer.Enabled = false;
                BOuvrir.Enabled = false;
                BEnregistrer.Enabled = false;
                BModifier.Enabled = false;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                int indexSupprime = lbPersonne.SelectedIndex;
                int numeroSupprime = listeNumeroEncodage[indexSupprime];

                lbPersonne.Items.RemoveAt(indexSupprime);
                listeNumeroEncodage.RemoveAt(indexSupprime);

                // Décrémenter les numéros supérieurs au numéro supprimé
                for (int i = 0; i < listeNumeroEncodage.Count; i++)
                {
                    if (listeNumeroEncodage[i] > numeroSupprime)
                    {
                        listeNumeroEncodage[i]--;
                    }
                }
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
                if (indexModification == -1)
                {
                    // Ajout
                    lbPersonne.Items.Add($"{nom} ({qualite})");
                    listeNumeroEncodage.Add(prochainNumeroEncodage);
                    prochainNumeroEncodage++;
                }
                else
                {
                    // Modification
                    lbPersonne.Items[indexModification] = $"{nom} ({qualite})";
                    indexModification = -1;
                }

                txtNom.Clear();
                cboQualite.SelectedIndex = -1;

                lbPersonne.Enabled = true;
                BAjouter.Enabled = true;
                BSupprimer.Enabled = true;
                BOuvrir.Enabled = true;
                BEnregistrer.Enabled = true;
                BModifier.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;

                groupBox1.Enabled = false;
                BConfirmer.Enabled = false;
                BAnnuler.Enabled = false;
                cboQualite.Enabled = false;
                txtNom.Enabled = false;
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
            indexModification = -1;

            lbPersonne.Enabled = true;
            BAjouter.Enabled = true;
            BSupprimer.Enabled = true;
            BOuvrir.Enabled = true;
            BEnregistrer.Enabled = true;
            BModifier.Enabled = true;

            groupBox1.Enabled = false;
            BConfirmer.Enabled = false;
            BAnnuler.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
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
                listeNumeroEncodage.Clear();
                prochainNumeroEncodage = 1;

                try
                {
                    string[] lignes = File.ReadAllLines(NomFichier);
                    foreach (string ligne in lignes)
                    {
                        if (!string.IsNullOrEmpty(ligne))
                        {
                            // Extraire le numéro d'encodage
                            int indexDiese = ligne.LastIndexOf('#');
                            if (indexDiese > 0)
                            {
                                string donneeAffichee = ligne.Substring(0, indexDiese).Trim();
                                string numeroStr = ligne.Substring(indexDiese + 1).Trim();

                                if (int.TryParse(numeroStr, out int numero))
                                {
                                    lbPersonne.Items.Add(donneeAffichee);
                                    listeNumeroEncodage.Add(numero);
                                    prochainNumeroEncodage = Math.Max(prochainNumeroEncodage, numero + 1);
                                }
                            }
                            else
                            {
                                lbPersonne.Items.Add(ligne);
                                listeNumeroEncodage.Add(prochainNumeroEncodage);
                                prochainNumeroEncodage++;
                            }
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
                    for (int i = 0; i < lbPersonne.Items.Count; i++)
                    {
                        string item = lbPersonne.Items[i].ToString();
                        int numero = listeNumeroEncodage[i];
                        lignes.Add($"{item} #{numero}");
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
                int numero = listeNumeroEncodage[index];
                MessageBox.Show($"Données: {item}\nNuméro de ligne (index): {index}\nNuméro d'encodage: {numero}", "Détails", MessageBoxButtons.OK, MessageBoxIcon.Information);
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