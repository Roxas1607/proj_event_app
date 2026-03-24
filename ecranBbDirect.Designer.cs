namespace proj_event_app
{
    partial class ficBbDirect
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
            lbConsole = new ListBox();
            bConsulter = new Button();
            bDemonbrer = new Button();
            bAjouter = new Button();
            lPrenom = new Label();
            lNom = new Label();
            tbPrenom = new TextBox();
            tbNom = new TextBox();
            SuspendLayout();
            // 
            // lbConsole
            // 
            lbConsole.FormattingEnabled = true;
            lbConsole.Location = new Point(12, 19);
            lbConsole.Name = "lbConsole";
            lbConsole.Size = new Size(561, 404);
            lbConsole.TabIndex = 0;
            // 
            // bConsulter
            // 
            bConsulter.Location = new Point(593, 28);
            bConsulter.Name = "bConsulter";
            bConsulter.Size = new Size(94, 29);
            bConsulter.TabIndex = 1;
            bConsulter.Text = "Consulter";
            bConsulter.UseVisualStyleBackColor = true;
            bConsulter.Click += bConsulter_Click;
            // 
            // bDemonbrer
            // 
            bDemonbrer.Location = new Point(593, 152);
            bDemonbrer.Name = "bDemonbrer";
            bDemonbrer.Size = new Size(94, 29);
            bDemonbrer.TabIndex = 2;
            bDemonbrer.Text = "Demonbrer";
            bDemonbrer.UseVisualStyleBackColor = true;
            bDemonbrer.Click += bDemonbrer_Click;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(596, 394);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(94, 29);
            bAjouter.TabIndex = 3;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            bAjouter.Click += bAjouter_Click;
            // 
            // lPrenom
            // 
            lPrenom.AutoSize = true;
            lPrenom.Location = new Point(593, 232);
            lPrenom.Name = "lPrenom";
            lPrenom.Size = new Size(60, 20);
            lPrenom.TabIndex = 4;
            lPrenom.Text = "Prenom";
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Location = new Point(593, 313);
            lNom.Name = "lNom";
            lNom.Size = new Size(42, 20);
            lNom.TabIndex = 5;
            lNom.Text = "Nom";
            // 
            // tbPrenom
            // 
            tbPrenom.Location = new Point(596, 255);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(125, 27);
            tbPrenom.TabIndex = 6;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(596, 345);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(125, 27);
            tbNom.TabIndex = 7;
            // 
            // ficBbDirect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbNom);
            Controls.Add(tbPrenom);
            Controls.Add(lNom);
            Controls.Add(lPrenom);
            Controls.Add(bAjouter);
            Controls.Add(bDemonbrer);
            Controls.Add(bConsulter);
            Controls.Add(lbConsole);
            Name = "ficBbDirect";
            Text = "ficBbDirect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbConsole;
        private Button bConsulter;
        private Button bDemonbrer;
        private Button bAjouter;
        private Label lPrenom;
        private Label lNom;
        private TextBox tbPrenom;
        private TextBox tbNom;
    }
}