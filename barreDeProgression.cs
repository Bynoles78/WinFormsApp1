using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class barreDeProgression : Form
    {
        public barreDeProgression()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;

            for (int i = 0; i <= 10; i++)
            {
                progressBar1.Value = i*10;

                for (int j = 0; j <= 100; j++)
                {
                    progressBar2.Value = j;
                    await Task.Delay(10);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
