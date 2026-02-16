using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
namespace proj_event_app
{
    public partial class ecranListe : Form
    {

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int smLire = 0x0199;
        private const int smEcrire = 0x019A;


        string NomFichier = @"C:\";
        
        int numero = 0;
        bool fichierModifie = false;
        void Activer(bool activer)
        {

            bAjouter.Enabled = activer;
            bEnregistrer.Enabled = activer;
            bOuvrir.Enabled = activer;
            bSupprimer.Enabled = activer;
            gbDetail.Enabled = !activer;
            bModifier.Enabled = activer;
        }

        public ecranListe()
        {
            InitializeComponent();
        }

        private void ecranListe_Load(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
            fichierModifie = false;

        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {

            if (lbPersonne.SelectedIndex != -1)
            {
                lbPersonne.Items.RemoveAt(lbPersonne.SelectedIndex);

            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text;
            string qualite = tbQualite.Text;
           

            if (nom == "" || qualite == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return; 
            }
            
            string text = $"{nom} - {qualite}";

            if (fichierModifie)
            {
                int index = lbPersonne.SelectedIndex;
                lbPersonne.Items[index] = text;

                fichierModifie = true;
            }
            else
            {
                
                int index = lbPersonne.Items.Add(text);

                SendMessage(lbPersonne.Handle, smEcrire, index, numero);
                numero++;

                fichierModifie = false;
            }
            
           
            lbPersonne.Sorted = true;


        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bOuvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdOuvrirFichier = new OpenFileDialog();
            if (ofdOuvrirFichier.ShowDialog() == DialogResult.OK)
            {
                string NomFichier = ofdOuvrirFichier.FileName;
                lbPersonne.Sorted = false;
                foreach (string ligne in File.ReadAllLines(NomFichier))
                {
                    lbPersonne.Items.Add(ligne);
                }
            }

            lbPersonne.Sorted = true;
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdEnregistrer = new SaveFileDialog();

            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                string NomFichier = sfdEnregistrer.FileName;

                using (StreamWriter sw = new StreamWriter(NomFichier))
                {
                    foreach (var item in lbPersonne.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }
        }

        private void lbPersonne_DoubleClick(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                int index = lbPersonne.SelectedIndex;
                string valeur = lbPersonne.SelectedItem.ToString();
                int donneeCachee = SendMessage(lbPersonne.Handle, smLire, index,1);

                MessageBox.Show($"Index : {index}\nDonnées : {valeur}\ndonnee cachee : {donneeCachee}" );
            }
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {  
                Activer(false);
                fichierModifie = true;
              
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élément à modifier.");
            }





        }
    }
}
