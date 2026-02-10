namespace proj_event_app
{
    partial class fichier_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            controleToolStripMenuItem = new ToolStripMenuItem();
            ListeToolStripMenuItem = new ToolStripMenuItem();
            barreDeProgressionToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            editeurToolStripMenuItem = new ToolStripMenuItem();
            permutationToolStripMenuItem = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { controleToolStripMenuItem, applicationToolStripMenuItem, aideToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // controleToolStripMenuItem
            // 
            controleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ListeToolStripMenuItem, barreDeProgressionToolStripMenuItem, toolStripSeparator2, quitterToolStripMenuItem });
            controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            controleToolStripMenuItem.Size = new Size(80, 24);
            controleToolStripMenuItem.Text = "Controle";
            // 
            // ListeToolStripMenuItem
            // 
            ListeToolStripMenuItem.Name = "ListeToolStripMenuItem";
            ListeToolStripMenuItem.Size = new Size(229, 26);
            ListeToolStripMenuItem.Text = "Liste";
            // 
            // barreDeProgressionToolStripMenuItem
            // 
            barreDeProgressionToolStripMenuItem.Name = "barreDeProgressionToolStripMenuItem";
            barreDeProgressionToolStripMenuItem.Size = new Size(229, 26);
            barreDeProgressionToolStripMenuItem.Text = "Barre de Progression";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(226, 6);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(229, 26);
            quitterToolStripMenuItem.Text = "Quitter ";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editeurToolStripMenuItem, permutationToolStripMenuItem });
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(100, 24);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // editeurToolStripMenuItem
            // 
            editeurToolStripMenuItem.Name = "editeurToolStripMenuItem";
            editeurToolStripMenuItem.Size = new Size(224, 26);
            editeurToolStripMenuItem.Text = "Editeur";
            // 
            // permutationToolStripMenuItem
            // 
            permutationToolStripMenuItem.Name = "permutationToolStripMenuItem";
            permutationToolStripMenuItem.Size = new Size(224, 26);
            permutationToolStripMenuItem.Text = "permutation";
            permutationToolStripMenuItem.Click += permutationToolStripMenuItem_Click;
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposToolStripMenuItem1 });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new Size(54, 24);
            aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem1
            // 
            aProposToolStripMenuItem1.Name = "aProposToolStripMenuItem1";
            aProposToolStripMenuItem1.Size = new Size(153, 26);
            aProposToolStripMenuItem1.Text = "A propos";
            // 
            // fichier_principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fichier_principal";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem controleToolStripMenuItem;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem ListeToolStripMenuItem;
        private ToolStripMenuItem barreDeProgressionToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem editeurToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem permutationToolStripMenuItem;
    }
}
