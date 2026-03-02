using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_event_app
{
    public partial class ecranEditeur : Form
    {

        string sFichier;
        bool bmodifier;
        public ecranEditeur()
        {
            InitializeComponent();
            bmodifier = false;
            sFichier = null;
        }

        void fichierEnregistrer()
        {
            if (string.IsNullOrWhiteSpace(sFichier))
            {
                if (sfdEnregistrer.ShowDialog() != DialogResult.OK)
                    return;

                sFichier = sfdEnregistrer.FileName;
            }

            File.WriteAllText(sFichier, rtbTexte.Text);
            bmodifier = false;
        }

        bool verifierSauver()
        {
            if (!bmodifier)
                return true;

            DialogResult rep = MessageBox.Show(
                "Document modifié. Voulez-vous enregistrer le contenu de rtbTexte ?",
                "Enregistrement",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (rep == DialogResult.Cancel)
                return false;

            if (rep == DialogResult.Yes)
                fichierEnregistrer();

            return true;
        }

        void nouveauClick()
        {
            if (!verifierSauver())
                return;

            rtbTexte.Clear();
            sFichier = null;
            bmodifier = false;
        }

        void ouvrirClick()
        {
            if (!verifierSauver())
                return;

            if (ofdOuvrir.ShowDialog() != DialogResult.OK)
                return;

            sFichier = ofdOuvrir.FileName;
            rtbTexte.Text = File.ReadAllText(sFichier);
            bmodifier = false;
        }

        void quitterClick()
        {
            if (!verifierSauver())
                return;

            Close();
        }
        void appliquerstyle(FontStyle style)
        {
            if (rtbTexte.SelectionFont == null)
                return;

            Font currentFont = rtbTexte.SelectionFont;
            FontStyle newStyle = currentFont.Style;

            if (currentFont.Style.HasFlag(style))
                newStyle &= ~style;
            else
                newStyle |= style;

            rtbTexte.SelectionFont = new Font(currentFont, newStyle);
        }

    
       

        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            bmodifier = true;
        }

        private void miEnregistrer_Click(object sender, EventArgs e)
        {
            verifierSauver();
        }
        private void pbEnregistrer_Click(object sender, EventArgs e)
        {
            verifierSauver();
        }


        private void pbNouveau_Click(object sender, EventArgs e)
        {
            nouveauClick();
        }

        private void miNouveau_Click(object sender, EventArgs e)
        {
            nouveauClick();
        }


        private void pbOuvrir_Click(object sender, EventArgs e)
        {
            ouvrirClick();
        }

        private void miOuvrir_Click(object sender, EventArgs e)
        {
            ouvrirClick();
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            quitterClick();
        }

        private void miQuitter_Click(object sender, EventArgs e)
        {
            quitterClick();
        }

        private void miGras_Click(object sender, EventArgs e)
        {
            miGras.Checked = !miGras.Checked;
            appliquerstyle(FontStyle.Bold);
        }

        private void miItalique_Click(object sender, EventArgs e)
        {
            miItalique.Checked = !miItalique.Checked;
            appliquerstyle(FontStyle.Italic);
        }

        private void miSouligne_Click(object sender, EventArgs e)
        {
            miSouligne.Checked = !miSouligne.Checked;
            appliquerstyle(FontStyle.Underline);
        }

        private void miBarre_Click(object sender, EventArgs e)
        {
            miBarre.Checked = !miBarre.Checked; 
            appliquerstyle(FontStyle.Strikeout);
        }
    }
}
