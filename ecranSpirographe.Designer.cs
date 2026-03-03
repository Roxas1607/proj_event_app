namespace proj_event_app
{
    partial class ecranSpirographe
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
            gbParametre = new GroupBox();
            bGo = new Button();
            tbProfondeur = new TrackBar();
            tbDensite = new TrackBar();
            tbSommets = new TrackBar();
            lProfondeur = new Label();
            lDensite = new Label();
            lSommets = new Label();
            bTrait = new Button();
            bFond = new Button();
            cdCouleur = new ColorDialog();
            gbParametre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSommets).BeginInit();
            SuspendLayout();
            // 
            // gbParametre
            // 
            gbParametre.Controls.Add(bGo);
            gbParametre.Controls.Add(tbProfondeur);
            gbParametre.Controls.Add(tbDensite);
            gbParametre.Controls.Add(tbSommets);
            gbParametre.Controls.Add(lProfondeur);
            gbParametre.Controls.Add(lDensite);
            gbParametre.Controls.Add(lSommets);
            gbParametre.Location = new Point(12, 12);
            gbParametre.Name = "gbParametre";
            gbParametre.Size = new Size(250, 339);
            gbParametre.TabIndex = 0;
            gbParametre.TabStop = false;
            gbParametre.Text = "Parametre";
            // 
            // bGo
            // 
            bGo.Location = new Point(60, 288);
            bGo.Name = "bGo";
            bGo.Size = new Size(94, 29);
            bGo.TabIndex = 6;
            bGo.Text = "GO";
            bGo.UseVisualStyleBackColor = true;
            bGo.Click += bGo_Click;
            // 
            // tbProfondeur
            // 
            tbProfondeur.Location = new Point(29, 236);
            tbProfondeur.Name = "tbProfondeur";
            tbProfondeur.Size = new Size(191, 56);
            tbProfondeur.TabIndex = 5;
            tbProfondeur.Scroll += tbProfondeur_Scroll;
            // 
            // tbDensite
            // 
            tbDensite.Location = new Point(29, 135);
            tbDensite.Name = "tbDensite";
            tbDensite.Size = new Size(191, 56);
            tbDensite.TabIndex = 4;
            tbDensite.Scroll += tbDensite_Scroll;
            // 
            // tbSommets
            // 
            tbSommets.Location = new Point(28, 53);
            tbSommets.Name = "tbSommets";
            tbSommets.Size = new Size(192, 56);
            tbSommets.TabIndex = 3;
            tbSommets.Scroll += tbSommets_Scroll;
            // 
            // lProfondeur
            // 
            lProfondeur.AutoSize = true;
            lProfondeur.Location = new Point(29, 196);
            lProfondeur.Name = "lProfondeur";
            lProfondeur.Size = new Size(153, 20);
            lProfondeur.TabIndex = 2;
            lProfondeur.Text = "Profondeur du dessin ";
            // 
            // lDensite
            // 
            lDensite.AutoSize = true;
            lDensite.Location = new Point(29, 112);
            lDensite.Name = "lDensite";
            lDensite.Size = new Size(125, 20);
            lDensite.TabIndex = 1;
            lDensite.Text = "Densite du dessin";
            // 
            // lSommets
            // 
            lSommets.AutoSize = true;
            lSommets.Location = new Point(28, 30);
            lSommets.Name = "lSommets";
            lSommets.Size = new Size(151, 20);
            lSommets.TabIndex = 0;
            lSommets.Text = "Nombre de Sommets";
            // 
            // bTrait
            // 
            bTrait.Location = new Point(18, 380);
            bTrait.Name = "bTrait";
            bTrait.Size = new Size(94, 29);
            bTrait.TabIndex = 1;
            bTrait.Text = "Trait";
            bTrait.UseVisualStyleBackColor = true;
            bTrait.Click += bTrait_Click;
            // 
            // bFond
            // 
            bFond.Location = new Point(157, 380);
            bFond.Name = "bFond";
            bFond.Size = new Size(94, 29);
            bFond.TabIndex = 2;
            bFond.Text = "Fond";
            bFond.UseVisualStyleBackColor = true;
            bFond.Click += bFond_Click;
            // 
            // ecranSpirographe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bFond);
            Controls.Add(bTrait);
            Controls.Add(gbParametre);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "ecranSpirographe";
            Text = "ecranSpirographe";
            gbParametre.ResumeLayout(false);
            gbParametre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSommets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbParametre;
        private Label lProfondeur;
        private Label lDensite;
        private Label lSommets;
        private Button bGo;
        private TrackBar tbProfondeur;
        private TrackBar tbDensite;
        private TrackBar tbSommets;
        private Button bTrait;
        private Button bFond;
        private ColorDialog cdCouleur;
    }
}