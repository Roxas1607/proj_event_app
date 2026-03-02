namespace proj_event_app
{
    partial class ecranEditeur
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
            menuStrip1 = new MenuStrip();
            miFichier = new ToolStripMenuItem();
            miNouveau = new ToolStripMenuItem();
            miOuvrir = new ToolStripMenuItem();
            miEnregistrer = new ToolStripMenuItem();
            miQuitter = new ToolStripMenuItem();
            miEdition = new ToolStripMenuItem();
            copierToolStripMenuItem = new ToolStripMenuItem();
            miCouper = new ToolStripMenuItem();
            miColler = new ToolStripMenuItem();
            miFormat = new ToolStripMenuItem();
            miJustifier = new ToolStripMenuItem();
            miGauche = new ToolStripMenuItem();
            miCentre = new ToolStripMenuItem();
            miDroite = new ToolStripMenuItem();
            miPolice = new ToolStripMenuItem();
            miCaractere = new ToolStripMenuItem();
            miGras = new ToolStripMenuItem();
            miItalique = new ToolStripMenuItem();
            miSouligne = new ToolStripMenuItem();
            miBarre = new ToolStripMenuItem();
            pMenu = new Panel();
            pbQuitter = new PictureBox();
            pbEnregistrer = new PictureBox();
            pbOuvrir = new PictureBox();
            pbNouveau = new PictureBox();
            rtbTexte = new RichTextBox();
            fdPolice = new FontDialog();
            sfdEnregistrer = new SaveFileDialog();
            ofdOuvrir = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { miFichier, miEdition, miFormat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // miFichier
            // 
            miFichier.DropDownItems.AddRange(new ToolStripItem[] { miNouveau, miOuvrir, miEnregistrer, miQuitter });
            miFichier.Name = "miFichier";
            miFichier.Size = new Size(66, 24);
            miFichier.Text = "Fichier";
            // 
            // miNouveau
            // 
            miNouveau.Name = "miNouveau";
            miNouveau.Size = new Size(163, 26);
            miNouveau.Text = "Nouveau";
            miNouveau.Click += miNouveau_Click;
            // 
            // miOuvrir
            // 
            miOuvrir.Name = "miOuvrir";
            miOuvrir.Size = new Size(163, 26);
            miOuvrir.Text = "Ouvrir";
            miOuvrir.Click += miOuvrir_Click;
            // 
            // miEnregistrer
            // 
            miEnregistrer.Name = "miEnregistrer";
            miEnregistrer.Size = new Size(163, 26);
            miEnregistrer.Text = "Enregistrer";
            miEnregistrer.Click += miEnregistrer_Click;
            // 
            // miQuitter
            // 
            miQuitter.Name = "miQuitter";
            miQuitter.Size = new Size(163, 26);
            miQuitter.Text = "Quitter";
            miQuitter.Click += miQuitter_Click;
            // 
            // miEdition
            // 
            miEdition.DropDownItems.AddRange(new ToolStripItem[] { copierToolStripMenuItem, miCouper, miColler });
            miEdition.Name = "miEdition";
            miEdition.Size = new Size(70, 24);
            miEdition.Text = "Edition";
            // 
            // copierToolStripMenuItem
            // 
            copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            copierToolStripMenuItem.Size = new Size(140, 26);
            copierToolStripMenuItem.Text = "Copier";
            // 
            // miCouper
            // 
            miCouper.Name = "miCouper";
            miCouper.Size = new Size(140, 26);
            miCouper.Text = "Couper";
            // 
            // miColler
            // 
            miColler.Name = "miColler";
            miColler.Size = new Size(140, 26);
            miColler.Text = "Coller";
            // 
            // miFormat
            // 
            miFormat.DropDownItems.AddRange(new ToolStripItem[] { miJustifier, miPolice, miCaractere });
            miFormat.Name = "miFormat";
            miFormat.Size = new Size(70, 24);
            miFormat.Text = "Format";
            // 
            // miJustifier
            // 
            miJustifier.DropDownItems.AddRange(new ToolStripItem[] { miGauche, miCentre, miDroite });
            miJustifier.Name = "miJustifier";
            miJustifier.Size = new Size(224, 26);
            miJustifier.Text = "Justifier";
            // 
            // miGauche
            // 
            miGauche.Name = "miGauche";
            miGauche.Size = new Size(145, 26);
            miGauche.Text = "Gauche ";
            // 
            // miCentre
            // 
            miCentre.Name = "miCentre";
            miCentre.Size = new Size(145, 26);
            miCentre.Text = "Centre";
            // 
            // miDroite
            // 
            miDroite.Name = "miDroite";
            miDroite.Size = new Size(145, 26);
            miDroite.Text = "Droite";
            // 
            // miPolice
            // 
            miPolice.Name = "miPolice";
            miPolice.Size = new Size(224, 26);
            miPolice.Text = "Police";
            // 
            // miCaractere
            // 
            miCaractere.DropDownItems.AddRange(new ToolStripItem[] { miGras, miItalique, miSouligne, miBarre });
            miCaractere.Name = "miCaractere";
            miCaractere.Size = new Size(224, 26);
            miCaractere.Text = "Caractère";
            // 
            // miGras
            // 
            miGras.Name = "miGras";
            miGras.Size = new Size(224, 26);
            miGras.Text = "Gras";
            miGras.Click += miGras_Click;
            // 
            // miItalique
            // 
            miItalique.Name = "miItalique";
            miItalique.Size = new Size(224, 26);
            miItalique.Text = "Italique";
            miItalique.Click += miItalique_Click;
            // 
            // miSouligne
            // 
            miSouligne.Name = "miSouligne";
            miSouligne.Size = new Size(224, 26);
            miSouligne.Text = "Souligne";
            miSouligne.Click += miSouligne_Click;
            // 
            // miBarre
            // 
            miBarre.Name = "miBarre";
            miBarre.Size = new Size(224, 26);
            miBarre.Text = "Barre";
            miBarre.Click += miBarre_Click;
            // 
            // pMenu
            // 
            pMenu.Controls.Add(pbQuitter);
            pMenu.Controls.Add(pbEnregistrer);
            pMenu.Controls.Add(pbOuvrir);
            pMenu.Controls.Add(pbNouveau);
            pMenu.Location = new Point(12, 31);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(754, 37);
            pMenu.TabIndex = 1;
            // 
            // pbQuitter
            // 
            pbQuitter.Image = Properties.Resources.téléchargement1;
            pbQuitter.Location = new Point(132, 3);
            pbQuitter.Name = "pbQuitter";
            pbQuitter.Size = new Size(37, 31);
            pbQuitter.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitter.TabIndex = 3;
            pbQuitter.TabStop = false;
            pbQuitter.Click += pbQuitter_Click;
            // 
            // pbEnregistrer
            // 
            pbEnregistrer.Image = Properties.Resources._7570900;
            pbEnregistrer.Location = new Point(89, 3);
            pbEnregistrer.Name = "pbEnregistrer";
            pbEnregistrer.Size = new Size(37, 31);
            pbEnregistrer.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEnregistrer.TabIndex = 2;
            pbEnregistrer.TabStop = false;
            pbEnregistrer.Click += pbEnregistrer_Click;
            // 
            // pbOuvrir
            // 
            pbOuvrir.Image = Properties.Resources.téléchargement__1_;
            pbOuvrir.Location = new Point(46, 3);
            pbOuvrir.Name = "pbOuvrir";
            pbOuvrir.Size = new Size(37, 31);
            pbOuvrir.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOuvrir.TabIndex = 1;
            pbOuvrir.TabStop = false;
            pbOuvrir.Click += pbOuvrir_Click;
            // 
            // pbNouveau
            // 
            pbNouveau.Image = Properties.Resources.téléchargement__2_;
            pbNouveau.Location = new Point(3, 3);
            pbNouveau.Name = "pbNouveau";
            pbNouveau.Size = new Size(37, 31);
            pbNouveau.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNouveau.TabIndex = 0;
            pbNouveau.TabStop = false;
            pbNouveau.Click += pbNouveau_Click;
            // 
            // rtbTexte
            // 
            rtbTexte.Dock = DockStyle.Fill;
            rtbTexte.Location = new Point(0, 28);
            rtbTexte.Name = "rtbTexte";
            rtbTexte.Size = new Size(800, 422);
            rtbTexte.TabIndex = 2;
            rtbTexte.Text = "";
            rtbTexte.TextChanged += rtbTexte_TextChanged;
            // 
            // ofdOuvrir
            // 
            ofdOuvrir.FileName = "openFileDialog1";
            // 
            // ecranEditeur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbTexte);
            Controls.Add(pMenu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ecranEditeur";
            Text = "ecranEditeur";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQuitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem miFichier;
        private ToolStripMenuItem miNouveau;
        private ToolStripMenuItem miOuvrir;
        private ToolStripMenuItem miEnregistrer;
        private ToolStripMenuItem miQuitter;
        private ToolStripMenuItem miEdition;
        private ToolStripMenuItem copierToolStripMenuItem;
        private ToolStripMenuItem miCouper;
        private ToolStripMenuItem miColler;
        private ToolStripMenuItem miFormat;
        private ToolStripMenuItem miJustifier;
        private ToolStripMenuItem miGauche;
        private ToolStripMenuItem miCentre;
        private ToolStripMenuItem miDroite;
        private ToolStripMenuItem miPolice;
        private ToolStripMenuItem miCaractere;
        private ToolStripMenuItem miGras;
        private ToolStripMenuItem miItalique;
        private ToolStripMenuItem miSouligne;
        private ToolStripMenuItem miBarre;
        private Panel pMenu;
        private RichTextBox rtbTexte;
        private PictureBox pbQuitter;
        private PictureBox pbEnregistrer;
        private PictureBox pbOuvrir;
        private PictureBox pbNouveau;
        private FontDialog fdPolice;
        private SaveFileDialog sfdEnregistrer;
        private OpenFileDialog ofdOuvrir;
    }
}