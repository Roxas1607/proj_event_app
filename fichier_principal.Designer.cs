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
            controleMenuItem = new ToolStripMenuItem();
            ListeMenuItem = new ToolStripMenuItem();
            barreDeProgressionMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            quitterMenuItem = new ToolStripMenuItem();
            applicationMenuItem = new ToolStripMenuItem();
            editeurMenuItem = new ToolStripMenuItem();
            permutationMenuItem = new ToolStripMenuItem();
            aideMenuItem = new ToolStripMenuItem();
            aProposMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { controleMenuItem, applicationMenuItem, aideMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // controleMenuItem
            // 
            controleMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ListeMenuItem, barreDeProgressionMenuItem, toolStripSeparator2, quitterMenuItem });
            controleMenuItem.Name = "controleMenuItem";
            controleMenuItem.Size = new Size(80, 24);
            controleMenuItem.Text = "Controle";
            // 
            // ListeMenuItem
            // 
            ListeMenuItem.Name = "ListeMenuItem";
            ListeMenuItem.Size = new Size(229, 26);
            ListeMenuItem.Text = "Liste";
            ListeMenuItem.Click += ListeMenuItem_Click;
            // 
            // barreDeProgressionMenuItem
            // 
            barreDeProgressionMenuItem.Name = "barreDeProgressionMenuItem";
            barreDeProgressionMenuItem.Size = new Size(229, 26);
            barreDeProgressionMenuItem.Text = "Barre de Progression";
            barreDeProgressionMenuItem.Click += barreDeProgressionMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(226, 6);
            // 
            // quitterMenuItem
            // 
            quitterMenuItem.Name = "quitterMenuItem";
            quitterMenuItem.ShortcutKeyDisplayString = "Alt +q";
            quitterMenuItem.Size = new Size(229, 26);
            quitterMenuItem.Text = "Quitter ";
            // 
            // applicationMenuItem
            // 
            applicationMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editeurMenuItem, permutationMenuItem });
            applicationMenuItem.Name = "applicationMenuItem";
            applicationMenuItem.Size = new Size(100, 24);
            applicationMenuItem.Text = "Application";
            // 
            // editeurMenuItem
            // 
            editeurMenuItem.Name = "editeurMenuItem";
            editeurMenuItem.Size = new Size(224, 26);
            editeurMenuItem.Text = "Editeur";
            editeurMenuItem.Click += editeurMenuItem_Click;
            // 
            // permutationMenuItem
            // 
            permutationMenuItem.Name = "permutationMenuItem";
            permutationMenuItem.Size = new Size(224, 26);
            permutationMenuItem.Text = "permutation";
            permutationMenuItem.Click += permutationMenuItem_Click;
            // 
            // aideMenuItem
            // 
            aideMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposMenuItem1 });
            aideMenuItem.Name = "aideMenuItem";
            aideMenuItem.Size = new Size(54, 24);
            aideMenuItem.Text = "Aide";
            // 
            // aProposMenuItem1
            // 
            aProposMenuItem1.Name = "aProposMenuItem1";
            aProposMenuItem1.Size = new Size(153, 26);
            aProposMenuItem1.Text = "A propos";
            aProposMenuItem1.Click += aProposMenuItem1_Click;
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
        private ToolStripMenuItem controleMenuItem;
        private ToolStripMenuItem applicationMenuItem;
        private ToolStripMenuItem ListeMenuItem;
        private ToolStripMenuItem barreDeProgressionMenuItem;
        private ToolStripMenuItem quitterMenuItem;
        private ToolStripMenuItem aideMenuItem;
        private ToolStripMenuItem editeurMenuItem;
        private ToolStripMenuItem aProposMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem permutationMenuItem;
    }
}
