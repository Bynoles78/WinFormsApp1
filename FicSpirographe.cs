using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FicSpirographe : Form
    {
        private Color cFond = Color.White;
        private Color cTrait = Color.Black;
        private GraphicsPath gpSauvegarde = null;

        public FicSpirographe()
        {
            InitializeComponent();
        }

        private void FicSpirographe_Load(object sender, EventArgs e)
        {
            cFond = Color.White;
            cTrait = Color.Black;
            gpSauvegarde = null;
        }

        private void FicSpirographe_Paint(object sender, PaintEventArgs e)
        {
            if (gpSauvegarde != null)
            {
                e.Graphics.FillRectangle(
                    new SolidBrush(cFond),
                    new Rectangle(new Point(248, 0), ClientSize));
                e.Graphics.DrawPath(new Pen(cTrait), gpSauvegarde);
            }
        }

        private void BFond_Click(object sender, EventArgs e)
        {
            cdCouleur.Color = cFond;
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                cFond = cdCouleur.Color;
                Invalidate();
            }
        }

        private void BTrait_Click(object sender, EventArgs e)
        {
            cdCouleur.Color = cTrait;
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                cTrait = cdCouleur.Color;
                Invalidate();
            }
        }

        private void BGo_Click(object sender, EventArgs e)
        {
            int iSommets = tbSommets.Value;
            int iDensite = tbDensite.Value;
            int iProfondeur = tbProfondeur.Value;

            // Calculer le centre et le rayon
            int xc = 248 + (ClientSize.Width - 248) / 2;
            int yc = ClientSize.Height / 2;
            int rayon = Math.Min(ClientSize.Width - 248, ClientSize.Height) / 3;

            // Initialiser les tableaux des sommets
            double[] sx = new double[iSommets + 1];
            double[] sy = new double[iSommets + 1];

            // Calculer les sommets du polygone initial
            for (int i = 0; i <= iSommets; i++)
            {
                sx[i] = xc + rayon * Math.Cos(2 * Math.PI * i / iSommets);
                sy[i] = yc + rayon * Math.Sin(2 * Math.PI * i / iSommets);
            }

            gpSauvegarde = new GraphicsPath();

            // Dessiner les polygônes successifs jusqu'à convergence
            while (true)
            {
                // Vérifier la convergence
                double distanceMin = Math.Sqrt(
                    Math.Pow(sx[0] - xc, 2) + Math.Pow(sy[0] - yc, 2));

                if (distanceMin < rayon * iProfondeur / 100.0)
                    break;

                // Dessiner le polygône
                PointF[] points = new PointF[iSommets + 1];
                for (int i = 0; i <= iSommets; i++)
                {
                    points[i] = new PointF((float)sx[i], (float)sy[i]);
                }
                gpSauvegarde.AddLines(points);

                // Appliquer la densité
                for (int i = 0; i < iSommets; i++)
                {
                    sx[i] = sx[i] + (sx[i + 1] - sx[i]) / iDensite;
                    sy[i] = sy[i] + (sy[i + 1] - sy[i]) / iDensite;
                }
            }

            Invalidate();
        }

        private void TbSommets_Scroll(object sender, EventArgs e)
        {
            lSommets.Text = $"Sommets: {tbSommets.Value}";
        }

        private void TbDensite_Scroll(object sender, EventArgs e)
        {
            lDensite.Text = $"Densité: {tbDensite.Value}";
        }

        private void TbProfondeur_Scroll(object sender, EventArgs e)
        {
            lProfondeur.Text = $"Profondeur: {tbProfondeur.Value}";
        }
    }
}