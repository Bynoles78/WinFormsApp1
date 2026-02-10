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
            MessageBox.Show("Fonction non implémentée");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}