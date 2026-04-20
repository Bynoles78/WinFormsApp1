using WinFormsApp2;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MenubarreDeProgression_click(object sender, EventArgs e)
        {
            barreDeProgression nvBDP = new barreDeProgression();
            nvBDP.ShowDialog();
        }
        private void MenuListe_click(object sender, EventArgs e)
        {
            listPage nvlist = new listPage();
            nvlist.ShowDialog();
        }
        private void MenuQuitter_click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MenuAPropos_click(object sender, EventArgs e)
        {
            Apropos nvAP = new Apropos();
            nvAP.ShowDialog();
        }
        private void MenuEditer_click(object sender, EventArgs e)
        {
            Editer nvEditer = new Editer();
            nvEditer.ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ficSpiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicSpirographe nvficspirographe = new FicSpirographe();
            nvficspirographe.ShowDialog();
        }
        private void ficHorlogeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicHorloge nvHorloge = new FicHorloge();
            nvHorloge.ShowDialog();
        }
        private void ecranClavierSourisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranClavierSouris nvECS = new EcranClavierSouris();
            nvECS.ShowDialog();
        }
        private void ecranExplorateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicExplorateur nvEXPLO = new FicExplorateur();
            nvEXPLO.ShowDialog();
        }
        private void histogrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicHistogramme nvHisto = new FicHistogramme();
            nvHisto.ShowDialog();
        }
        private void integrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicIntegration nvIntegration = new FicIntegration();
            nvIntegration.ShowDialog();
        }
    }
}