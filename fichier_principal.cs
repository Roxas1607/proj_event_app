namespace proj_event_app
{
    public partial class fichier_principal : Form
    {
        public fichier_principal()
        {
            InitializeComponent();
            quitterMenuItem.Click += quitterMenuItem_Click;
        }

        void quitterMenuItem_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        void default_message()
        {
            MessageBox.Show("pas encore de methode implante");

        }
        private void permutationMenuItem_Click(object sender, EventArgs e)
        {
            Form ecran_permutation = new ecranPermutation();
            ecran_permutation.ShowDialog();
        }

        private void aProposMenuItem1_Click(object sender, EventArgs e)
        {
            Form ecran_apropos = new ecranApropos();
            ecran_apropos.ShowDialog();
        }

        private void ListeMenuItem_Click(object sender, EventArgs e)
        {
            Form ecran_liste = new ecranListe();
            ecran_liste.ShowDialog();
        }

        private void editeurMenuItem_Click(object sender, EventArgs e)
        {
            Form ecran_editeur = new ecranEditeur();
            ecran_editeur.ShowDialog();
        }

        private void barreDeProgressionMenuItem_Click(object sender, EventArgs e)
        {

            Form ecran_progression = new ecranProgession();
            ecran_progression.ShowDialog();
        }

        private void spirographeMenuItem_Click(object sender, EventArgs e)
        {
            Form ecran_spirographe = new ecranSpirographe();
            ecran_spirographe.ShowDialog();
        }

        private void sourisClavierMenuItem_Click(object sender, EventArgs e)
        {
            Form ecran_SourisClavier = new ecranSourisClavier();
            ecran_SourisClavier.ShowDialog();
        }

        private void explorateurWindowsMenuItem_Click(object sender, EventArgs e)
        {
            Form ecran_explorateur = new ecranExplorateur();
            ecran_explorateur.ShowDialog();
        }
    }
}
