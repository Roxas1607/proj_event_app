namespace proj_event_app
{
    partial class ecranPermutation
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
            bpermutation = new Button();
            bNewEcran = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // bpermutation
            // 
            bpermutation.Location = new Point(197, 261);
            bpermutation.Name = "bpermutation";
            bpermutation.Size = new Size(122, 29);
            bpermutation.TabIndex = 0;
            bpermutation.Text = "Permutation";
            bpermutation.UseVisualStyleBackColor = true;
            bpermutation.Click += bpermutation_Click;
            // 
            // bNewEcran
            // 
            bNewEcran.Location = new Point(496, 261);
            bNewEcran.Name = "bNewEcran";
            bNewEcran.Size = new Size(94, 29);
            bNewEcran.TabIndex = 1;
            bNewEcran.Text = "new ecran ";
            bNewEcran.UseVisualStyleBackColor = true;
            bNewEcran.Click += bNewEcran_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vaisseau_alien;
            pictureBox1.Location = new Point(173, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._3d_printer_300x350;
            pictureBox2.Location = new Point(496, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(187, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // ecranPermutation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bNewEcran);
            Controls.Add(bpermutation);
            Name = "ecranPermutation";
            Text = "ecranPermutation";
           
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bpermutation;
        private Button bNewEcran;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}