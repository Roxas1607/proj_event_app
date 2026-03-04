using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_event_app
{
    public partial class ecranSourisClavier : Form
    {
        int nbGauche, nbDroite;
        public ecranSourisClavier()
        {
            InitializeComponent();

        }

        void AfficherClic()
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                nbGauche++;
                tbxClicGauche.Text = $"clic gauche {nbGauche}";

            }
            else if (Control.MouseButtons == MouseButtons.Right)
            {
                nbDroite++;
                tbxClicDroit.Text = $"clic droite {nbDroite}";
            }

        }
        private void pnlSouris_MouseDown(object sender, MouseEventArgs e)
        {
            AfficherClic();

            int colonne = (e.X / (pnlSouris.Width / 3)) + 1;
            int ligne = (e.Y / (pnlSouris.Height / 3)) + 1;
            lsbClavier.Items.Add("clic Colonne "+ colonne+ " Ligne "+ ligne);

        }

        private void pnlSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbxPositionX.Text = $"PositionX {e.X}";
            tbxPositionY.Text = $"PositionY {e.Y}";

        }

        private void lsbClavier_KeyDown(object sender, KeyEventArgs e)
        {
            lsbClavier.Items.Add("KeyDown : " + e.KeyCode);
        }

        private void lsbClavier_KeyPress(object sender, KeyPressEventArgs e)
        {
            lsbClavier.Items.Add("KeyPress : " + e.KeyChar);
        }

        private void lsbClavier_KeyUp(object sender, KeyEventArgs e)
        {
            lsbClavier.Items.Add("KeyUp : " + e.KeyCode);
        }

        private void butRAZ_Click(object sender, EventArgs e)
        {
            lsbClavier.Items.Clear();
            tbxClicDroit.Text = "0";
            nbDroite = 0;
            nbGauche = 0;
            tbxClicGauche.Text = "0";
            tbxPositionX.Text = "0";
            tbxPositionY.Text = "0";

        }

        private void pnlSouris_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen monCrayon = new Pen(Color.Black, 1); 

            int largeur = pnlSouris.Width;
            int hauteur = pnlSouris.Height;
         
            g.DrawLine(monCrayon, largeur / 3, 0, largeur / 3, hauteur);
            g.DrawLine(monCrayon, (largeur / 3) * 2, 0, (largeur / 3) * 2, hauteur);

            g.DrawLine(monCrayon, 0, hauteur / 3, largeur, hauteur / 3);

            g.DrawLine(monCrayon, 0, (hauteur / 3) * 2, largeur, (hauteur / 3) * 2);
            monCrayon.Dispose();
        }
    }
}
