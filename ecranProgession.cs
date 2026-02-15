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
    public partial class ecranProgession : Form
    {
        Random rnd = new Random();
        public ecranProgession()
        {
            InitializeComponent();
            bQuitter.Click += bQuitter_Click;
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void bExecuter_Click(object sender, EventArgs e)
        {
            bExecuter.Enabled = false;
            this.Cursor = Cursors.WaitCursor;



            int nbFichiers = 5;

            pbPrincipal.Value = 0;
            pbPrincipal.Maximum = nbFichiers;

            for (int i = 0; i < nbFichiers; i++)
            {
                int taille = 100 ;

                pbSecondaire.Value = 0;
                pbSecondaire.Maximum = taille;

                for (int j = 0; j < taille; j++)
                {
                    pbSecondaire.Value = j + 1;
                    await Task.Delay(15);
                    
                }

                pbPrincipal.Value = i + 1;
                pbPrincipal.Refresh();
            }

            this.Cursor = Cursors.Default;
            bExecuter.Enabled = true;
        }
    }
}
