namespace proj_event_app
{
    partial class ecranProgession
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
            lPrincipal = new Label();
            lSecondaire = new Label();
            pbPrincipal = new ProgressBar();
            pbSecondaire = new ProgressBar();
            bExecuter = new Button();
            bQuitter = new Button();
            SuspendLayout();
            // 
            // lPrincipal
            // 
            lPrincipal.AutoSize = true;
            lPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lPrincipal.Location = new Point(24, 21);
            lPrincipal.Name = "lPrincipal";
            lPrincipal.Size = new Size(140, 28);
            lPrincipal.TabIndex = 0;
            lPrincipal.Text = "Index principal";
            // 
            // lSecondaire
            // 
            lSecondaire.AutoSize = true;
            lSecondaire.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSecondaire.Location = new Point(24, 159);
            lSecondaire.Name = "lSecondaire";
            lSecondaire.Size = new Size(161, 28);
            lSecondaire.TabIndex = 1;
            lSecondaire.Text = "Index Secondaire";
            // 
            // pbPrincipal
            // 
            pbPrincipal.Location = new Point(24, 79);
            pbPrincipal.Name = "pbPrincipal";
            pbPrincipal.Size = new Size(259, 50);
            pbPrincipal.TabIndex = 2;
            // 
            // pbSecondaire
            // 
            pbSecondaire.Location = new Point(24, 216);
            pbSecondaire.Name = "pbSecondaire";
            pbSecondaire.Size = new Size(259, 51);
            pbSecondaire.TabIndex = 3;
            // 
            // bExecuter
            // 
            bExecuter.Location = new Point(24, 317);
            bExecuter.Name = "bExecuter";
            bExecuter.Size = new Size(103, 48);
            bExecuter.TabIndex = 4;
            bExecuter.Text = "Executer";
            bExecuter.UseVisualStyleBackColor = true;
            bExecuter.Click += bExecuter_Click;
            // 
            // bQuitter
            // 
            bQuitter.Location = new Point(169, 317);
            bQuitter.Name = "bQuitter";
            bQuitter.Size = new Size(103, 48);
            bQuitter.TabIndex = 5;
            bQuitter.Text = "Quitter";
            bQuitter.UseVisualStyleBackColor = true;
            bQuitter.Click += bQuitter_Click;
            // 
            // ecranProgession
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bQuitter);
            Controls.Add(bExecuter);
            Controls.Add(pbSecondaire);
            Controls.Add(pbPrincipal);
            Controls.Add(lSecondaire);
            Controls.Add(lPrincipal);
            Name = "ecranProgession";
            Text = "Barres de Progression";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lPrincipal;
        private Label lSecondaire;
        private ProgressBar pbPrincipal;
        private ProgressBar pbSecondaire;
        private Button bExecuter;
        private Button bQuitter;
    }
}