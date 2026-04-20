using System;
using System.Drawing;
using System.Windows.Forms;

public delegate double fctAIntegrer(double x);

namespace WinFormsApp1
{
    public partial class FicIntegration : Form
    {
        public FicIntegration()
        {
            InitializeComponent();
        }
        private void bPolynome_Click(object sender, EventArgs e)
        {
            try
            {
                double gauche = double.Parse(tbGauche.Text);
                double droite = double.Parse(tbDroite.Text);
                int nBase = int.Parse(tbNbInt.Text);

                lbResultats.Items.Clear();
                lbResultats.Items.Add("Méthode des trapèzes (Traditionnelle)");
                lbResultats.Items.Add("Polynôme: x² + 2");

                for (int i = 0; i <= 4; i++)
                {
                    int n = nBase * (int)Math.Pow(2, i);
                    double h = (droite - gauche) / n;
                    double aire = 0;

                    for (int j = 0; j < n; j++)
                    {
                        double xA = gauche + (j * h);
                        double xB = xA + h;
                        double fA = (xA * xA) + 2;
                        double fB = (xB * xB) + 2;
                        aire += (fA + fB) * h / 2;
                    }
                    lbResultats.Items.Add($"Nb Int: {n} => {aire}");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void bTrigonometrique_Click(object sender, EventArgs e)
        {
            try
            {
                double gauche = double.Parse(tbGauche.Text);
                double droite = double.Parse(tbDroite.Text);
                int nBase = int.Parse(tbNbInt.Text);

                lbResultats.Items.Clear();
                lbResultats.Items.Add("Méthode des trapèzes (Traditionnelle)");
                lbResultats.Items.Add("Trigonométrique: sin(x)");

                for (int i = 0; i <= 4; i++)
                {
                    int n = nBase * (int)Math.Pow(2, i);
                    double h = (droite - gauche) / n;
                    double aire = 0;

                    for (int j = 0; j < n; j++)
                    {
                        double xA = gauche + (j * h);
                        double xB = xA + h;
                        aire += (Math.Sin(xA) + Math.Sin(xB)) * h / 2;
                    }
                    lbResultats.Items.Add($"Nb Int: {n} => {aire}");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private double MonPolynome(double x)
        {
            return (x * x) + 2;
        }
        double IntegrationTrapeze(fctAIntegrer f, double xGauche, double xDroite, int nInterval)
        {
            double h = (xDroite - xGauche) / nInterval;
            double sommeAire = 0;

            for (int i = 0; i < nInterval; i++)
            {
                double a = xGauche + (i * h);
                double b = a + h;

                sommeAire += (f(a) + f(b)) * h / 2;
            }
            return sommeAire;
        }
        private void bPointeurPolynome_Click(object sender, EventArgs e)
        {
            CalculerEtAfficher(MonPolynome, "Polynôme: x² + 2");
        }
        private void bPointeurTrigonometrique_Click(object sender, EventArgs e)
        {

            CalculerEtAfficher(Math.Sin, "Trigonométrique: sin(x)");
        }

        private void CalculerEtAfficher(fctAIntegrer fonction, string titre)
        {
            try
            {
                double gauche = double.Parse(tbGauche.Text);
                double droite = double.Parse(tbDroite.Text);
                int nBase = int.Parse(tbNbInt.Text);

                if (nBase < 1) nBase = 1;

                lbResultats.Items.Clear();
                lbResultats.Items.Add("Méthode des trapèzes");
                lbResultats.Items.Add(titre);

                for (int i = 0; i <= 4; i++)
                {
                    int nActuel = nBase * (int)Math.Pow(2, i);
                    double resultat = IntegrationTrapeze(fonction, gauche, droite, nActuel);

                    lbResultats.Items.Add($"Nb Int: {nActuel} => {resultat}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez vérifier vos saisies : " + ex.Message);
            }
        }
    }
}