namespace proj_event_app
{
    public partial class fichier_principal : Form
    {
        public fichier_principal()
        {
            InitializeComponent();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void ListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void permutationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ecran_permutation = new ecranPermutation();
            ecran_permutation.ShowDialog();
        }
    }
}
