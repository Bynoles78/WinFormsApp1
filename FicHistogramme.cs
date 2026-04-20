using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FicHistogramme : Form
    {
        private ArrayList alData = new ArrayList();
        private Random rnd = new Random();

        public FicHistogramme()
        {
            InitializeComponent();
        }

        public class MonPoint
        {
            private int x, y;
            public int X { get { return x; } set { x = value; } }

            public int Y { get { return y; } set { y = value; } }


            public MonPoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return "(" + x + "," + y + ")";
            }
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            alData.Clear();
            lbMonPoint.Items.Clear();
            int xActuel = 0;

            int nbPoints = rnd.Next(5, 15);
            for (int i = 0; i < nbPoints; i++)
            {
                xActuel += rnd.Next(5, 40);
                int yVal = rnd.Next(-100, 101);

                MonPoint p = new MonPoint(xActuel, yVal);
                alData.Add(p);
                lbMonPoint.Items.Add(p);
            }
        }

        private void bDessiner_Click(object sender, EventArgs e)
        {
            pDessin.Invalidate();
        }

        private void pDessin_Paint(object sender, PaintEventArgs e)
        {
            if (alData.Count < 2) return;

            Graphics g = e.Graphics;
            Pen stylo = new Pen(Color.Navy, 2);

            g.DrawLine(Pens.Red, 0, pDessin.Height / 2, pDessin.Width, pDessin.Height / 2);
            for (int i = 0; i < alData.Count - 1; i++)
            {
                MonPoint p1 = (MonPoint)alData[i];
                MonPoint p2 = (MonPoint)alData[i + 1];


                int x1 = p1.X;
                int y1 = (pDessin.Height / 2) - p1.Y;
                int x2 = p2.X;
                int y2 = (pDessin.Height / 2) - p2.Y;


                g.DrawLine(stylo, x1, y1, x2, y1);

                g.DrawLine(stylo, x2, y1, x2, y2);
            }
        }

        private void FicHistogramme_Load(object sender, EventArgs e)
        {

        }
    }
}