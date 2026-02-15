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
            default_message();
        }

        private void editeurMenuItem_Click(object sender, EventArgs e)
        {
            default_message();
        }

        private void barreDeProgressionMenuItem_Click(object sender, EventArgs e)
        {

            Form ecran_progression = new ecranProgession();
            ecran_progression.ShowDialog();
        }
    }
}
