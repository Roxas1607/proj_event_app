using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_event_app
{
    public partial class ecranSpirographe : Form
    {
        public ecranSpirographe()
        {
            InitializeComponent();
            cTrait = Color.Red;
            cFond = Color.Blue;
            gpSauvegarde = null;
            this.Paint += redimenssion;
            this.Resize += (s, e) => { polygone(); Invalidate(); };
            this.Shown += (s, e) => { polygone(); Invalidate(); };
            this.DoubleBuffered = true;

            tbSommets.Minimum = 3;
            tbSommets.Maximum = 8;
            tbSommets.Value = 5;
            tbDensite.Minimum = 1;
            tbDensite.Maximum = 50;
            tbProfondeur.Minimum = 0;
            tbProfondeur.Maximum = 100;
            tbProfondeur.Value = 10;

        }

        Color cTrait;
        Color cFond;
        GraphicsPath gpSauvegarde;


        Rectangle dessin()
        {
            int marge = 8;
            int x = gbParametre.Right + marge;

            if (x >= ClientSize.Width)
            {
                x = ClientSize.Width - 1;
            }// sécurité

            return new Rectangle(
                x,
                0,
                Math.Max(1, ClientSize.Width - x),
                ClientSize.Height

            );
        }

        void redimenssion(object? sender, PaintEventArgs e)
        {

            Rectangle rect = dessin();


            using (var b = new SolidBrush(cFond))
                e.Graphics.FillRectangle(b, rect);

            if (gpSauvegarde != null)
            {
                using (var p = new Pen(cTrait))
                    e.Graphics.DrawPath(p, gpSauvegarde);
            }
        }


        void polygone()
        {
            Rectangle rect = dessin();

            PointF centre = new PointF(
                rect.Left + rect.Width / 2f,
                rect.Top + rect.Height / 2f
            );

            int nbSommets = tbSommets.Value;
            int densite = tbDensite.Value;
            int iProfondeur = tbProfondeur.Value;

            if (densite < 1) densite = 1;

            float rayon = Math.Min(rect.Width, rect.Height) * 0.4f;
            float limite = rayon * iProfondeur / 100f;

            gpSauvegarde?.Dispose();
            gpSauvegarde = new GraphicsPath();

            // Polygone initial
            PointF[] points = new PointF[nbSommets];

            for (int i = 0; i < nbSommets; i++)
            {
                double angle = -Math.PI / 2 + i * 2 * Math.PI / nbSommets;

                points[i] = new PointF(
                    centre.X + rayon * (float)Math.Cos(angle),
                    centre.Y + rayon * (float)Math.Sin(angle)
                );
            }

            int securite = 5000;


            // Boucle jusqu'à ce que la distance au centre soit inférieure à la limite
            while (distance(points[0], centre) > limite && securite-- > 0)
            {
                gpSauvegarde.AddPolygon(points);
                points = appliquerDensite(points, densite);
            }
        }

        PointF[] appliquerDensite(PointF[] s, int iDensite)
        {
            int n = s.Length;
            PointF[] nouv = new PointF[n];

            for (int i = 0; i < n; i++)
            {
                int j = (i + 1) % n;

                nouv[i] = new PointF(
                    s[i].X + (s[j].X - s[i].X) / iDensite,
                    s[i].Y + (s[j].Y - s[i].Y) / iDensite
                );
            }

            return nouv;
        }

        float distance(PointF a, PointF b)
        {
            float dx = a.X - b.X;
            float dy = a.Y - b.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }


        private void tbSommets_Scroll(object sender, EventArgs e)
        {
            polygone();
            Invalidate();
        }

        private void tbDensite_Scroll(object sender, EventArgs e)
        {
            polygone();
            Invalidate();
        }

        private void tbProfondeur_Scroll(object sender, EventArgs e)
        {
            polygone();
            Invalidate();
        }

        private void bTrait_Click(object sender, EventArgs e)
        {
            cdCouleur.Color = cTrait;
            if (cdCouleur.ShowDialog(this) == DialogResult.OK)
            {
                cTrait = cdCouleur.Color;
                Invalidate(dessin());
            }
        }
        private void bFond_Click(object sender, EventArgs e)
        {
            cdCouleur.Color = cFond;
            if (cdCouleur.ShowDialog(this) == DialogResult.OK)
            {
                cFond = cdCouleur.Color;
                Invalidate(dessin());
            }
        }

        private void bGo_Click(object sender, EventArgs e)
        { 
            new ecranHorloge().Show();
        }
    }
}
