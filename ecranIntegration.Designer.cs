namespace proj_event_app
{
    partial class ecranIntegration
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
            lGauche = new Label();
            lDroite = new Label();
            lNbint = new Label();
            tbGauche = new TextBox();
            tbDroit = new TextBox();
            tbNbInt = new TextBox();
            lbResultats = new ListBox();
            bPolynome = new Button();
            bTrigonometrique = new Button();
            bPointeurPolynome = new Button();
            bPointeurTrigonometrique = new Button();
            SuspendLayout();
            // 
            // lGauche
            // 
            lGauche.AutoSize = true;
            lGauche.Location = new Point(76, 41);
            lGauche.Name = "lGauche";
            lGauche.Size = new Size(58, 20);
            lGauche.TabIndex = 0;
            lGauche.Text = "Gauche";
            // 
            // lDroite
            // 
            lDroite.AutoSize = true;
            lDroite.Location = new Point(305, 41);
            lDroite.Name = "lDroite";
            lDroite.Size = new Size(51, 20);
            lDroite.TabIndex = 1;
            lDroite.Text = "Droite";
            // 
            // lNbint
            // 
            lNbint.AutoSize = true;
            lNbint.Location = new Point(559, 41);
            lNbint.Name = "lNbint";
            lNbint.Size = new Size(94, 20);
            lNbint.TabIndex = 2;
            lNbint.Text = "NB intervalle";
            // 
            // tbGauche
            // 
            tbGauche.Location = new Point(77, 80);
            tbGauche.Name = "tbGauche";
            tbGauche.Size = new Size(125, 27);
            tbGauche.TabIndex = 3;
            // 
            // tbDroit
            // 
            tbDroit.Location = new Point(305, 80);
            tbDroit.Name = "tbDroit";
            tbDroit.Size = new Size(125, 27);
            tbDroit.TabIndex = 4;
            // 
            // tbNbInt
            // 
            tbNbInt.Location = new Point(559, 80);
            tbNbInt.Name = "tbNbInt";
            tbNbInt.Size = new Size(125, 27);
            tbNbInt.TabIndex = 5;
            // 
            // lbResultats
            // 
            lbResultats.FormattingEnabled = true;
            lbResultats.Location = new Point(76, 135);
            lbResultats.Name = "lbResultats";
            lbResultats.Size = new Size(402, 204);
            lbResultats.TabIndex = 6;
            // 
            // bPolynome
            // 
            bPolynome.Location = new Point(86, 360);
            bPolynome.Name = "bPolynome";
            bPolynome.Size = new Size(94, 29);
            bPolynome.TabIndex = 7;
            bPolynome.Text = "Polynome";
            bPolynome.UseVisualStyleBackColor = true;
            bPolynome.Click += bPolynome_Click;
            // 
            // bTrigonometrique
            // 
            bTrigonometrique.Location = new Point(72, 409);
            bTrigonometrique.Name = "bTrigonometrique";
            bTrigonometrique.Size = new Size(139, 29);
            bTrigonometrique.TabIndex = 8;
            bTrigonometrique.Text = "Trigonometrique";
            bTrigonometrique.UseVisualStyleBackColor = true;
            bTrigonometrique.Click += bTrigonometrique_Click;
            // 
            // bPointeurPolynome
            // 
            bPointeurPolynome.Location = new Point(286, 360);
            bPointeurPolynome.Name = "bPointeurPolynome";
            bPointeurPolynome.Size = new Size(172, 29);
            bPointeurPolynome.TabIndex = 9;
            bPointeurPolynome.Text = "Idem pointeur";
            bPointeurPolynome.UseVisualStyleBackColor = true;
            bPointeurPolynome.Click += bPointeurPolynome_Click;
            // 
            // bPointeurTrigonometrique
            // 
            bPointeurTrigonometrique.Location = new Point(286, 409);
            bPointeurTrigonometrique.Name = "bPointeurTrigonometrique";
            bPointeurTrigonometrique.Size = new Size(153, 29);
            bPointeurTrigonometrique.TabIndex = 10;
            bPointeurTrigonometrique.Text = "Idem pointeur";
            bPointeurTrigonometrique.UseVisualStyleBackColor = true;
            bPointeurTrigonometrique.Click += bPointeurTrigonometrique_Click;
            // 
            // ecranIntegration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bPointeurTrigonometrique);
            Controls.Add(bPointeurPolynome);
            Controls.Add(bTrigonometrique);
            Controls.Add(bPolynome);
            Controls.Add(lbResultats);
            Controls.Add(tbNbInt);
            Controls.Add(tbDroit);
            Controls.Add(tbGauche);
            Controls.Add(lNbint);
            Controls.Add(lDroite);
            Controls.Add(lGauche);
            Name = "ecranIntegration";
            Text = "ecranIntegration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lGauche;
        private Label lDroite;
        private Label lNbint;
        private TextBox tbGauche;
        private TextBox tbDroit;
        private TextBox tbNbInt;
        private ListBox lbResultats;
        private Button b;
        private Button bTrigonometrique;
        private Button bPointeurPolynome;
        private Button bPointeurTrigonometrique;
        private Button bPolynome;
    }
}