using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EcranClavierSouris : Form
    {
        private int nbGauche = 0;
        private int nbDroit = 0;

        public EcranClavierSouris()
        {
            InitializeComponent();
        }

        private void EcranClavierSouris_Load(object sender, EventArgs e)
        {
            AfficherClic();
        }

        private void AfficherClic()
        {
            tbxClicGauche.Text = nbGauche.ToString();
            tbxClicDroit.Text = nbDroit.ToString();
        }

        private void PnlSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbxPositionX.Text = e.X.ToString();
            tbxPositionY.Text = e.Y.ToString();
        }

        private void PnlSouris_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                nbGauche++;
                int ligne = DetermineLigne(e.Y);
                int colonne = DetermineColonne(e.X);
                lsbClavier.Items.Add($"Clic gauche - Case [Ligne {ligne}, Colonne {colonne}]");
            }
            else if (e.Button == MouseButtons.Right)
            {
                nbDroit++;
                int ligne = DetermineLigne(e.Y);
                int colonne = DetermineColonne(e.X);
                lsbClavier.Items.Add($"Clic droit - Case [Ligne {ligne}, Colonne {colonne}]");
            }

            AfficherClic();
            tbxPositionX.Text = e.X.ToString();
            tbxPositionY.Text = e.Y.ToString();
        }

        private int DetermineLigne(int y)
        {
            int hauteurCase = pnlSouris.Height / 3;
            if (y < hauteurCase)
                return 0;
            else if (y < 2 * hauteurCase)
                return 1;
            else
                return 2;
        }

        private int DetermineColonne(int x)
        {
            int largeurCase = pnlSouris.Width / 3;
            if (x < largeurCase)
                return 0;
            else if (x < 2 * largeurCase)
                return 1;
            else
                return 2;
        }
        private void EcranClavierSouris_KeyPress(object sender, KeyPressEventArgs e)
        {
            lsbClavier.Items.Add($"Press - Caractère '{e.KeyChar}'");
            lsbClavier.TopIndex = lsbClavier.Items.Count - 1;
        }

        //private void EcranClavierSouris_KeyDown(object sender, KeyEventArgs e)
        //{
        //    lsbClavier.Items.Add($"Down - Code {e.KeyCode}, Value {(int)e.KeyCode}");
        //    lsbClavier.TopIndex = lsbClavier.Items.Count - 1;
        //    e.Handled = false;
        //}

        //private void EcranClavierSouris_KeyUp(object sender, KeyEventArgs e)
        //{
        //    lsbClavier.Items.Add($"Up - Code {e.KeyCode}, Value {(int)e.KeyCode}");
        //    lsbClavier.TopIndex = lsbClavier.Items.Count - 1;
        //}

        private void PnlSouris_Paint(object sender, PaintEventArgs e)
        {
            // Dessiner les lignes de division
            int largeur = pnlSouris.Width;
            int hauteur = pnlSouris.Height;

            Pen linePen = new Pen(Color.Black, 2);

            // Lignes horizontales
            int hauteurCase = hauteur / 3;
            e.Graphics.DrawLine(linePen, 0, hauteurCase, largeur, hauteurCase);
            e.Graphics.DrawLine(linePen, 0, 2 * hauteurCase, largeur, 2 * hauteurCase);

            // Lignes verticales
            int largeurCase = largeur / 3;
            e.Graphics.DrawLine(linePen, largeurCase, 0, largeurCase, hauteur);
            e.Graphics.DrawLine(linePen, 2 * largeurCase, 0, 2 * largeurCase, hauteur);
        }

        private void ButRAZ_Click(object sender, EventArgs e)
        {
            nbGauche = 0;
            nbDroit = 0;
            AfficherClic();
            tbxPositionX.Text = "0";
            tbxPositionY.Text = "0";
            lsbClavier.Items.Clear();
        }
    }
}