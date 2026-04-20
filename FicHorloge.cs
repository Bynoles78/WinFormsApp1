using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FicHorloge : Form
    {
        private Color cFond;
        private Color cTrait;

        public FicHorloge()
        {
            InitializeComponent();
            cTrait = Color.Black;
            cFond = Color.White;

            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(cFond);

            int xc = ClientSize.Width / 2;
            int yc = ClientSize.Height / 2;
            int rayon = Math.Min(xc, yc) - 20;

            DateTime mnt = DateTime.Now;
            this.Text = mnt.ToLongTimeString();

            using (Pen pCadran = new Pen(cTrait, 2))
            {
                g.DrawEllipse(pCadran, xc - rayon, yc - rayon, rayon * 2, rayon * 2);
            }

            DessinerCadran(g, xc, yc, rayon, new Pen(cTrait, 2));
        
            double angS = (mnt.Second * 6 * Math.PI / 180.0) - Math.PI / 2.0;
            double angM = ((mnt.Minute + mnt.Second / 60.0) * 6 * Math.PI / 180.0) - Math.PI / 2.0;
            double angH = ((mnt.Hour % 12 + mnt.Minute / 60.0) * 30 * Math.PI / 180.0) - Math.PI / 2.0;

       
            using (Pen pS = new Pen(Color.Red, 1))
                DessinerAiguille(g, xc, yc, angS, rayon * 0.9, pS);

            using (Pen pM = new Pen(Color.Black, 3))
                DessinerAiguille(g, xc, yc, angM, rayon * 0.8, pM);

            using (Pen pH = new Pen(Color.Black, 5))
                DessinerAiguille(g, xc, yc, angH, rayon * 0.6, pH);
        }

        protected void DessinerAiguille(Graphics g, int xc, int yc, double angleRad, double longueur, Pen p)
        {
            float xBout = (float)(xc + longueur * Math.Cos(angleRad));
            float yBout = (float)(yc + longueur * Math.Sin(angleRad));

            g.DrawLine(p, xc, yc, xBout, yBout);
        }

        protected void DessinerCadran(Graphics g, int xc, int yc, int rayon, Pen p)
        {
            for (int i = 0; i < 12; i++)
            {
                double angleRad = (i * 30 * Math.PI / 180.0) - Math.PI / 2.0;
                float xStart = (float)(xc + (rayon - 20) * Math.Cos(angleRad));
                float yStart = (float)(yc + (rayon - 20) * Math.Sin(angleRad));
                float xEnd = (float)(xc + rayon * Math.Cos(angleRad));
                float yEnd = (float)(yc + rayon * Math.Sin(angleRad));
                g.DrawLine(p, xStart, yStart, xEnd, yEnd);
            }
          
        }

        protected void tTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}