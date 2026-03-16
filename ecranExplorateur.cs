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
namespace proj_event_app
{
    public partial class ecranExplorateur : Form
    {
        public ecranExplorateur()
        {
            InitializeComponent();
            RemplirTreeView();
        }

        string NomFichier(string chemin)
        {
            return Path.GetFileNameWithoutExtension(chemin);
        }

        void LireRepertoires(string chemin, TreeNode noeudParent)
        {
            if (!Directory.Exists(chemin))
                return;

            try
            {
                string[] repertoires = Directory.GetDirectories(chemin);

                foreach (string rep in repertoires)
                {
                    string nom = Path.GetFileName(rep);

                    TreeNode noeudRep = new TreeNode(nom);
                    noeudParent.Nodes.Add(noeudRep);

                    LireRepertoires(rep, noeudRep);
                }
            }
            catch
            {

            }
        }
        void LireDisques()
        {
            string[] disques = Environment.GetLogicalDrives();

            foreach (string disque in disques)
            {
                TreeNode noeudDisque = new TreeNode(disque);
                tvRepertoire.Nodes.Add(noeudDisque);

                LireRepertoires(disque, noeudDisque);
            }
        }



        void LireFichiers(string chemin)
        {
            lvFichiers.Items.Clear();

            try
            {
                string[] fichiers = Directory.GetFiles(chemin);

                foreach (string f in fichiers)
                {
                    FileInfo info = new FileInfo(f);

                    ListViewItem item = new ListViewItem(NomFichier(f));

                    item.SubItems.Add(info.Length.ToString());
                    item.SubItems.Add(info.CreationTime.ToString());
                    item.SubItems.Add(info.LastWriteTime.ToString());

                    lvFichiers.Items.Add(item);
                }
            }
            catch
            {
                // ignore les erreurs d'accès
            }
        }


        void RemplirTreeView()
        {
            tvRepertoire.Nodes.Clear();
            LireDisques();
        }

        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string chemin = e.Node.FullPath;

            if (!chemin.Contains("Poste de travail"))
            {
                LireFichiers(chemin);
            }
        }

        private void tsaPetitsIcones_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.SmallIcon;
        }

        private void tsaGrandesIcones_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.LargeIcon;
        }

        private void tsaListe_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.List;
        }

        private void tsaDetail_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.Details;
        }
    }
}
