using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace proj_event_app
{
    public partial class ecranHistogramme : Form
    {
        ArrayList alData = new ArrayList();
        Random rnd = new Random();
        public ecranHistogramme()
        {
            InitializeComponent();
            pDessin.BackColor = Color.White;
        }



        private void bCreer_Click(object sender, EventArgs e)
        {
            alData.Clear();
            lbMonPoint.Items.Clear();

            int nbPoints = rnd.Next(5, 15);
            int dernierX = 0;

            for (int i = 0; i < nbPoints; i++)
            {
                dernierX += rnd.Next(10, 50);
                int y = rnd.Next(-100, 101);
                MonPoint mp = new MonPoint(dernierX, y);
                alData.Add(mp);
                lbMonPoint.Items.Add(mp);
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
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Bornes
            int minX = ((MonPoint)alData[0]).X;
            int maxX = ((MonPoint)alData[alData.Count - 1]).X;
            int minY = -100;
            int maxY = 100;

            // Eviter la division par zéro si minX == maxX
            float rangeX = (maxX - minX == 0) ? 1 : (maxX - minX);
            float scaleX = pDessin.Width / rangeX;
            float scaleY = (float)pDessin.Height / (maxY - minY);

            PointF[] pointsDessin = new PointF[alData.Count];
            for (int i = 0; i < alData.Count; i++)
            {
                MonPoint mp = (MonPoint)alData[i];
                float x = (mp.X - minX) * scaleX;
              
                float y = pDessin.Height - ((mp.Y - minY) * scaleY);
                pointsDessin[i] = new PointF(x, y);
            }

            g.DrawLines(new Pen(Color.Blue, 2), pointsDessin);
        }

    }
    public class MonPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public MonPoint(int x, int y) { X = x; Y = y; }
        public override string ToString() => $"[{X} ; {Y}]";
    }

    public class HistoPoint : MonPoint
    {
        public HistoPoint(int x, int y) : base(x, y) { }
    }

}
