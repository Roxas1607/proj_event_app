using System;
using System.IO;
using System.Windows.Forms;

namespace proj_event_app
{
    public partial class ecranExplorateur : Form
    {
        public ecranExplorateur()
        {
            InitializeComponent();
            RemplirTreeView();
            tvRepertoire.BeforeExpand += tvRepertoire_BeforeExpand;
        }

        void RemplirTreeView()
        {
            tvRepertoire.Nodes.Clear();
            TreeNode root = new TreeNode("Poste de travail");
            tvRepertoire.Nodes.Add(root);

            foreach (string disque in Environment.GetLogicalDrives())
            {
                TreeNode noeudDisque = new TreeNode(disque);
                noeudDisque.Tag = disque;
               
                noeudDisque.Nodes.Add(new TreeNode("Chargement..."));
                root.Nodes.Add(noeudDisque);
            }
            root.Expand();
        }

      
        private void tvRepertoire_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode nodeParent = e.Node;

          
            if (nodeParent.Tag != null && nodeParent.Nodes.Count > 0 && nodeParent.Nodes[0].Tag == null)
            {
                nodeParent.Nodes.Clear();
                string chemin = nodeParent.Tag.ToString();

                try
                {
                    foreach (string dir in Directory.GetDirectories(chemin))
                    {
                        TreeNode nodeChild = new TreeNode(Path.GetFileName(dir));
                        nodeChild.Tag = dir;
                       
                        nodeChild.Nodes.Add(new TreeNode("Chargement..."));
                        nodeParent.Nodes.Add(nodeChild);
                    }
                }
                catch { /* Accès refusé sur certains dossiers système */ }
            }
        }

        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                LireFichiers(e.Node.Tag.ToString());
            }
        }

        void LireFichiers(string chemin)
        {
            lvFichiers.BeginUpdate();
            lvFichiers.Items.Clear();
            try
            {
                if (Directory.Exists(chemin))
                {
                    foreach (string f in Directory.GetFiles(chemin))
                    {
                        FileInfo info = new FileInfo(f);
                        ListViewItem item = new ListViewItem(Path.GetFileNameWithoutExtension(f));
                        item.SubItems.Add((info.Length / 1024).ToString() + " Ko");
                        item.SubItems.Add(info.CreationTime.ToShortDateString());
                        item.SubItems.Add(info.LastWriteTime.ToShortDateString());
                        lvFichiers.Items.Add(item);
                    }
                }
            }
            catch { }
            lvFichiers.EndUpdate();
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