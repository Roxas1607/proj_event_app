namespace proj_event_app
{
    partial class ecranListe
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
            lFichier = new Label();
            lbPersonne = new ListBox();
            bOuvrir = new Button();
            bEnregistrer = new Button();
            bAjouter = new Button();
            bSupprimer = new Button();
            gbDetail = new GroupBox();
            tbQualite = new TextBox();
            tbNom = new TextBox();
            bAnnuler = new Button();
            bConfirmer = new Button();
            lNom = new Label();
            lQualite = new Label();
            bModifier = new Button();
            gbDetail.SuspendLayout();
            SuspendLayout();
            // 
            // lFichier
            // 
            lFichier.AutoSize = true;
            lFichier.Location = new Point(40, 28);
            lFichier.Name = "lFichier";
            lFichier.Size = new Size(112, 20);
            lFichier.TabIndex = 0;
            lFichier.Text = "Nom du fichier ";
            // 
            // lbPersonne
            // 
            lbPersonne.FormattingEnabled = true;
            lbPersonne.Location = new Point(40, 63);
            lbPersonne.Name = "lbPersonne";
            lbPersonne.Size = new Size(581, 184);
            lbPersonne.TabIndex = 1;
            lbPersonne.DoubleClick += lbPersonne_DoubleClick;
            // 
            // bOuvrir
            // 
            bOuvrir.Location = new Point(50, 276);
            bOuvrir.Name = "bOuvrir";
            bOuvrir.Size = new Size(94, 29);
            bOuvrir.TabIndex = 2;
            bOuvrir.Text = "Ouvrir";
            bOuvrir.UseVisualStyleBackColor = true;
            bOuvrir.Click += bOuvrir_Click;
            // 
            // bEnregistrer
            // 
            bEnregistrer.Location = new Point(50, 329);
            bEnregistrer.Name = "bEnregistrer";
            bEnregistrer.Size = new Size(94, 29);
            bEnregistrer.TabIndex = 3;
            bEnregistrer.Text = "Enregistrer";
            bEnregistrer.UseVisualStyleBackColor = true;
            bEnregistrer.Click += bEnregistrer_Click;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(50, 428);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(94, 29);
            bAjouter.TabIndex = 4;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            bAjouter.Click += bAjouter_Click;
            // 
            // bSupprimer
            // 
            bSupprimer.Location = new Point(50, 478);
            bSupprimer.Name = "bSupprimer";
            bSupprimer.Size = new Size(94, 29);
            bSupprimer.TabIndex = 5;
            bSupprimer.Text = "Supprimer";
            bSupprimer.UseVisualStyleBackColor = true;
            bSupprimer.Click += bSupprimer_Click;
            // 
            // gbDetail
            // 
            gbDetail.Controls.Add(tbQualite);
            gbDetail.Controls.Add(tbNom);
            gbDetail.Controls.Add(bAnnuler);
            gbDetail.Controls.Add(bConfirmer);
            gbDetail.Controls.Add(lNom);
            gbDetail.Controls.Add(lQualite);
            gbDetail.Location = new Point(290, 276);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(331, 253);
            gbDetail.TabIndex = 6;
            gbDetail.TabStop = false;
            gbDetail.Text = "Detail personne";
            // 
            // tbQualite
            // 
            tbQualite.Location = new Point(17, 69);
            tbQualite.Name = "tbQualite";
            tbQualite.Size = new Size(125, 27);
            tbQualite.TabIndex = 7;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(17, 152);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(125, 27);
            tbNom.TabIndex = 6;
            // 
            // bAnnuler
            // 
            bAnnuler.Location = new Point(192, 202);
            bAnnuler.Name = "bAnnuler";
            bAnnuler.Size = new Size(94, 29);
            bAnnuler.TabIndex = 5;
            bAnnuler.Text = "Annuler";
            bAnnuler.UseVisualStyleBackColor = true;
            bAnnuler.Click += bAnnuler_Click;
            // 
            // bConfirmer
            // 
            bConfirmer.Location = new Point(34, 204);
            bConfirmer.Name = "bConfirmer";
            bConfirmer.Size = new Size(94, 29);
            bConfirmer.TabIndex = 4;
            bConfirmer.Text = "Confirmer";
            bConfirmer.UseVisualStyleBackColor = true;
            bConfirmer.Click += bConfirmer_Click;
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Location = new Point(17, 108);
            lNom.Name = "lNom";
            lNom.Size = new Size(42, 20);
            lNom.TabIndex = 1;
            lNom.Text = "Nom";
            // 
            // lQualite
            // 
            lQualite.AutoSize = true;
            lQualite.Location = new Point(17, 33);
            lQualite.Name = "lQualite";
            lQualite.Size = new Size(57, 20);
            lQualite.TabIndex = 0;
            lQualite.Text = "Qualite";
            // 
            // bModifier
            // 
            bModifier.Location = new Point(50, 384);
            bModifier.Name = "bModifier";
            bModifier.Size = new Size(94, 29);
            bModifier.TabIndex = 7;
            bModifier.Text = "Modifier";
            bModifier.UseVisualStyleBackColor = true;
            bModifier.Click += bModifier_Click;
            // 
            // ecranListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(bModifier);
            Controls.Add(gbDetail);
            Controls.Add(bSupprimer);
            Controls.Add(bAjouter);
            Controls.Add(bEnregistrer);
            Controls.Add(bOuvrir);
            Controls.Add(lbPersonne);
            Controls.Add(lFichier);
            Name = "ecranListe";
            Text = "Manipulation d'une liste";
            Load += ecranListe_Load;
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lFichier;
        private ListBox lbPersonne;
        private Button bOuvrir;
        private Button bEnregistrer;
        private Button bAjouter;
        private Button bSupprimer;
        private GroupBox gbDetail;
        private CheckBox checkBox1;
        private Label lNom;
        private Label lQualite;
        private Button bAnnuler;
        private Button bConfirmer;
        private TextBox tbQualite;
        private TextBox tbNom;
        private Button bModifier;
    }
}