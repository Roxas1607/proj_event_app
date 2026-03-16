namespace proj_event_app
{
    partial class ecranExplorateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbCommandes = new ToolStrip();
            tbsQuitter = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tbsddbApparence = new ToolStripDropDownButton();
            tsaPetitsIcones = new ToolStripMenuItem();
            tsaGrandesIcones = new ToolStripMenuItem();
            tsaListe = new ToolStripMenuItem();
            tsaDetail = new ToolStripMenuItem();
            ssMessage = new StatusStrip();
            slMessage = new ToolStripStatusLabel();
            scSeparateur = new SplitContainer();
            tvRepertoire = new TreeView();
            lvFichiers = new ListView();
            NOM = new ColumnHeader();
            TAIL = new ColumnHeader();
            MODI = new ColumnHeader();
            CREA = new ColumnHeader();
            ilTreeVieuw = new ImageList(components);
            ilGrand = new ImageList(components);
            ilPetit = new ImageList(components);
            tbCommandes.SuspendLayout();
            ssMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scSeparateur).BeginInit();
            scSeparateur.Panel1.SuspendLayout();
            scSeparateur.Panel2.SuspendLayout();
            scSeparateur.SuspendLayout();
            SuspendLayout();
            // 
            // tbCommandes
            // 
            tbCommandes.ImageScalingSize = new Size(20, 20);
            tbCommandes.Items.AddRange(new ToolStripItem[] { tbsQuitter, toolStripSeparator1, tbsddbApparence });
            tbCommandes.Location = new Point(0, 0);
            tbCommandes.Name = "tbCommandes";
            tbCommandes.Size = new Size(800, 27);
            tbCommandes.TabIndex = 0;
            tbCommandes.Text = "toolStrip1";
            // 
            // tbsQuitter
            // 
            tbsQuitter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbsQuitter.Image = Properties.Resources.téléchargement1;
            tbsQuitter.ImageTransparentColor = Color.Magenta;
            tbsQuitter.Name = "tbsQuitter";
            tbsQuitter.Size = new Size(29, 24);
            tbsQuitter.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // tbsddbApparence
            // 
            tbsddbApparence.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbsddbApparence.DropDownItems.AddRange(new ToolStripItem[] { tsaPetitsIcones, tsaGrandesIcones, tsaListe, tsaDetail });
            tbsddbApparence.Image = Properties.Resources.téléchargement__1_;
            tbsddbApparence.ImageTransparentColor = Color.Magenta;
            tbsddbApparence.Name = "tbsddbApparence";
            tbsddbApparence.Size = new Size(34, 24);
            tbsddbApparence.Text = "toolStripDropDownButton1";
            // 
            // tsaPetitsIcones
            // 
            tsaPetitsIcones.Name = "tsaPetitsIcones";
            tsaPetitsIcones.Size = new Size(192, 26);
            tsaPetitsIcones.Text = "Petits Icones";
            tsaPetitsIcones.Click += tsaPetitsIcones_Click;
            // 
            // tsaGrandesIcones
            // 
            tsaGrandesIcones.Name = "tsaGrandesIcones";
            tsaGrandesIcones.Size = new Size(192, 26);
            tsaGrandesIcones.Text = "Grandes Icones";
            tsaGrandesIcones.Click += tsaGrandesIcones_Click;
            // 
            // tsaListe
            // 
            tsaListe.Name = "tsaListe";
            tsaListe.Size = new Size(192, 26);
            tsaListe.Text = "Liste";
            tsaListe.Click += tsaListe_Click;
            // 
            // tsaDetail
            // 
            tsaDetail.Name = "tsaDetail";
            tsaDetail.Size = new Size(192, 26);
            tsaDetail.Text = "Detail";
            tsaDetail.Click += tsaDetail_Click;
            // 
            // ssMessage
            // 
            ssMessage.ImageScalingSize = new Size(20, 20);
            ssMessage.Items.AddRange(new ToolStripItem[] { slMessage });
            ssMessage.Location = new Point(0, 424);
            ssMessage.Name = "ssMessage";
            ssMessage.Size = new Size(800, 26);
            ssMessage.TabIndex = 1;
            ssMessage.Text = "statusStrip1";
            // 
            // slMessage
            // 
            slMessage.Name = "slMessage";
            slMessage.Size = new Size(77, 20);
            slMessage.Text = "Bienvenue";
            // 
            // scSeparateur
            // 
            scSeparateur.Dock = DockStyle.Fill;
            scSeparateur.Location = new Point(0, 27);
            scSeparateur.Name = "scSeparateur";
            // 
            // scSeparateur.Panel1
            // 
            scSeparateur.Panel1.Controls.Add(tvRepertoire);
            // 
            // scSeparateur.Panel2
            // 
            scSeparateur.Panel2.Controls.Add(lvFichiers);
            scSeparateur.Size = new Size(800, 397);
            scSeparateur.SplitterDistance = 266;
            scSeparateur.TabIndex = 2;
            // 
            // tvRepertoire
            // 
            tvRepertoire.Dock = DockStyle.Fill;
            tvRepertoire.Location = new Point(0, 0);
            tvRepertoire.Name = "tvRepertoire";
            tvRepertoire.Size = new Size(266, 397);
            tvRepertoire.TabIndex = 0;
            tvRepertoire.AfterSelect += tvRepertoire_AfterSelect;
            // 
            // lvFichiers
            // 
            lvFichiers.Columns.AddRange(new ColumnHeader[] { NOM, TAIL, MODI, CREA });
            lvFichiers.Dock = DockStyle.Fill;
            lvFichiers.Location = new Point(0, 0);
            lvFichiers.Name = "lvFichiers";
            lvFichiers.Size = new Size(530, 397);
            lvFichiers.TabIndex = 0;
            lvFichiers.UseCompatibleStateImageBehavior = false;
            lvFichiers.View = View.Details;
            // 
            // NOM
            // 
            NOM.Text = "Nom";
            NOM.Width = 200;
            // 
            // TAIL
            // 
            TAIL.Text = "Taille";
            TAIL.Width = 80;
            // 
            // MODI
            // 
            MODI.DisplayIndex = 3;
            MODI.Text = "Modification";
            MODI.Width = 100;
            // 
            // CREA
            // 
            CREA.DisplayIndex = 2;
            CREA.Text = "Creation";
            CREA.Width = 100;
            // 
            // ilTreeVieuw
            // 
            ilTreeVieuw.ColorDepth = ColorDepth.Depth32Bit;
            ilTreeVieuw.ImageSize = new Size(16, 16);
            ilTreeVieuw.TransparentColor = Color.Transparent;
            // 
            // ilGrand
            // 
            ilGrand.ColorDepth = ColorDepth.Depth32Bit;
            ilGrand.ImageSize = new Size(16, 16);
            ilGrand.TransparentColor = Color.Transparent;
            // 
            // ilPetit
            // 
            ilPetit.ColorDepth = ColorDepth.Depth32Bit;
            ilPetit.ImageSize = new Size(16, 16);
            ilPetit.TransparentColor = Color.Transparent;
            // 
            // ecranExplorateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scSeparateur);
            Controls.Add(ssMessage);
            Controls.Add(tbCommandes);
            Name = "ecranExplorateur";
            Text = "ecranExplorateur";
            tbCommandes.ResumeLayout(false);
            tbCommandes.PerformLayout();
            ssMessage.ResumeLayout(false);
            ssMessage.PerformLayout();
            scSeparateur.Panel1.ResumeLayout(false);
            scSeparateur.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scSeparateur).EndInit();
            scSeparateur.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tbCommandes;
        private ToolStripButton tbsQuitter;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tbsddbApparence;
        private ToolStripMenuItem tsaPetitsIcones;
        private ToolStripMenuItem tsaGrandesIcones;
        private ToolStripMenuItem tsaListe;
        private ToolStripMenuItem tsaDetail;
        private StatusStrip ssMessage;
        private ToolStripStatusLabel slMessage;
        private SplitContainer scSeparateur;
        private TreeView tvRepertoire;
        private ImageList ilTreeVieuw;
        private ImageList ilGrand;
        private ImageList ilPetit;
        private ListView lvFichiers;
        private ColumnHeader NOM;
        private ColumnHeader TAIL;
        private ColumnHeader MODI;
        private ColumnHeader CREA;
    }
}