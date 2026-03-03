using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_event_app
{
    public partial class ecranHorloge: Form
    {
        private Color cFond;
        private Color cTrait;

        public ecranHorloge()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            cFond = Color.White;
            cTrait = Color.Black;

            timerHorloge.Interval = 50;
            timerHorloge.Tick += THorloge_Tick;

            this.Load += EcranHorloge_Load;
            this.Resize += EcranHorloge_Resize;
        }

        private void EcranHorloge_Load(object sender, EventArgs e)
        {
            timerHorloge.Start();
            Invalidate(ZoneDessin());
        }

        private void EcranHorloge_Resize(object sender, EventArgs e)
        {
            Invalidate(ZoneDessin());
        }

        private void THorloge_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.Text = $"Horloge - {now:HH:mm:ss}";
            Invalidate(ZoneDessin());
        }

        private Rectangle ZoneDessin()
        {
            int marge = 8;

            Control gb = this.Controls["gbParametrage"]; // optionnel
            int x = (gb != null) ? gb.Right + marge : 0;

            if (x >= ClientSize.Width) x = ClientSize.Width - 1;

            return new Rectangle(
                x,
                0,
                Math.Max(1, ClientSize.Width - x),
                ClientSize.Height
            );
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle zone = ZoneDessin();
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (SolidBrush sb = new SolidBrush(cFond))
            {
                e.Graphics.FillRectangle(sb, zone);
            }

            DessinerHorloge(e.Graphics, zone);
        }

        private void DessinerHorloge(Graphics g, Rectangle zone)
        {
            float xc = zone.Left + zone.Width / 2f;
            float yc = zone.Top + zone.Height / 2f;
            float rayon = Math.Min(zone.Width, zone.Height) / 2f - 12f;
            if (rayon <= 5f) return;

            DateTime now = DateTime.Now;

            double sec = now.Second + now.Millisecond / 1000.0;
            double min = now.Minute + sec / 60.0;
            double hr = (now.Hour % 12) + min / 60.0;

            double angSec = sec / 60.0 * 2.0 * Math.PI - Math.PI / 2.0;
            double angMin = min / 60.0 * 2.0 * Math.PI - Math.PI / 2.0;
            double angHr = hr / 12.0 * 2.0 * Math.PI - Math.PI / 2.0;

            using (Pen pCadran = new Pen(cTrait, 2f))
            using (Pen pHeure = new Pen(cTrait, 6f))
            using (Pen pMinute = new Pen(cTrait, 4f))
            using (Pen pSeconde = new Pen(cTrait, 2f))
            using (SolidBrush bCentre = new SolidBrush(cTrait))
            {
                g.DrawEllipse(pCadran, xc - rayon, yc - rayon, 2 * rayon, 2 * rayon);

                for (int i = 0; i < 12; i++)
                {
                    double a = i / 12.0 * 2.0 * Math.PI - Math.PI / 2.0;
                    float x1 = xc + (float)(Math.Cos(a) * (rayon * 0.85));
                    float y1 = yc + (float)(Math.Sin(a) * (rayon * 0.85));
                    float x2 = xc + (float)(Math.Cos(a) * (rayon * 0.98));
                    float y2 = yc + (float)(Math.Sin(a) * (rayon * 0.98));
                    g.DrawLine(pCadran, x1, y1, x2, y2);
                }

                DessinerAiguille(g, pHeure, xc, yc, rayon * 0.55f, angHr);
                DessinerAiguille(g, pMinute, xc, yc, rayon * 0.75f, angMin);
                DessinerAiguille(g, pSeconde, xc, yc, rayon * 0.85f, angSec);

                g.FillEllipse(bCentre, xc - 5f, yc - 5f, 10f, 10f);
            }
        }

        private static void DessinerAiguille(Graphics g, Pen p, float xc, float yc, float longueur, double angle)
        {
            float x = xc + (float)(Math.Cos(angle) * longueur);
            float y = yc + (float)(Math.Sin(angle) * longueur);
            g.DrawLine(p, xc, yc, x, y);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timerHorloge.Stop();
            base.OnFormClosed(e);
        }
    }
}


