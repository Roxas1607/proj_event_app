namespace proj_event_app
{
    partial class ecranApropos
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
            pictureBox1 = new PictureBox();
            lTitre = new Label();
            lVersion = new Label();
            panel1 = new Panel();
            lText = new Label();
            lCopyright = new Label();
            bConfirmer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.téléchargement;
            pictureBox1.Location = new Point(24, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lTitre
            // 
            lTitre.AutoSize = true;
            lTitre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTitre.Location = new Point(252, 16);
            lTitre.Name = "lTitre";
            lTitre.Size = new Size(258, 31);
            lTitre.TabIndex = 1;
            lTitre.Text = "Premiere Manipulations";
            // 
            // lVersion
            // 
            lVersion.AutoSize = true;
            lVersion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lVersion.Location = new Point(252, 93);
            lVersion.Name = "lVersion";
            lVersion.Size = new Size(257, 31);
            lVersion.TabIndex = 2;
            lVersion.Text = "version sous Alpha 1.0.0";
            lVersion.Click += lVersion_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lText);
            panel1.Controls.Add(lCopyright);
            panel1.Controls.Add(lVersion);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lTitre);
            panel1.Cursor = Cursors.SizeAll;
            panel1.Location = new Point(91, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 325);
            panel1.TabIndex = 3;
            panel1.MouseEnter += panel1_MouseEnter;
            // 
            // lText
            // 
            lText.AutoSize = true;
            lText.Location = new Point(241, 251);
            lText.Name = "lText";
            lText.Size = new Size(230, 40);
            lText.TabIndex = 4;
            lText.Text = "Et l'application se dit un jour elle \r\ndeviendra aussi grande que .NET";
            lText.Click += lText_Click;
            // 
            // lCopyright
            // 
            lCopyright.AutoSize = true;
            lCopyright.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lCopyright.Location = new Point(252, 159);
            lCopyright.Name = "lCopyright";
            lCopyright.Size = new Size(200, 31);
            lCopyright.TabIndex = 3;
            lCopyright.Text = "CopyRight NADA";
            // 
            // bConfirmer
            // 
            bConfirmer.BackColor = SystemColors.Control;
            bConfirmer.Cursor = Cursors.IBeam;
            bConfirmer.FlatAppearance.BorderColor = Color.DarkBlue;
            bConfirmer.FlatAppearance.BorderSize = 3;
            bConfirmer.FlatStyle = FlatStyle.Flat;
            bConfirmer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bConfirmer.ForeColor = SystemColors.ActiveCaption;
            bConfirmer.Location = new Point(332, 369);
            bConfirmer.Name = "bConfirmer";
            bConfirmer.Size = new Size(134, 41);
            bConfirmer.TabIndex = 4;
            bConfirmer.Text = "Confirmer";
            bConfirmer.UseVisualStyleBackColor = false;
            // 
            // ecranApropos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bConfirmer);
            Controls.Add(panel1);
            Name = "ecranApropos";
            Text = "ecranApropos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lTitre;
        private Label lVersion;
        private Panel panel1;
        private Label lCopyright;
        private Label lText;
        private Button bConfirmer;
    }
}