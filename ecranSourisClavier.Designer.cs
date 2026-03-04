namespace proj_event_app
{
    partial class ecranSourisClavier
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
            pnlSouris = new Panel();
            lblClicGauche = new Label();
            lblClicDroit = new Label();
            lblPositionX = new Label();
            lblPositionY = new Label();
            lblClavier = new Label();
            lsbClavier = new ListBox();
            butRAZ = new Button();
            tbxClicGauche = new TextBox();
            tbxClicDroit = new TextBox();
            tbxPositionX = new TextBox();
            tbxPositionY = new TextBox();
            SuspendLayout();
            // 
            // pnlSouris
            // 
            pnlSouris.BorderStyle = BorderStyle.FixedSingle;
            pnlSouris.Location = new Point(229, 87);
            pnlSouris.Name = "pnlSouris";
            pnlSouris.Size = new Size(571, 390);
            pnlSouris.TabIndex = 0;
            pnlSouris.Paint += pnlSouris_Paint;
            pnlSouris.MouseDown += pnlSouris_MouseDown;
            pnlSouris.MouseMove += pnlSouris_MouseMove;
            // 
            // lblClicGauche
            // 
            lblClicGauche.AutoSize = true;
            lblClicGauche.Location = new Point(229, 18);
            lblClicGauche.Name = "lblClicGauche";
            lblClicGauche.Size = new Size(86, 20);
            lblClicGauche.TabIndex = 1;
            lblClicGauche.Text = "Clic Gauche";
            // 
            // lblClicDroit
            // 
            lblClicDroit.AutoSize = true;
            lblClicDroit.Location = new Point(397, 18);
            lblClicDroit.Name = "lblClicDroit";
            lblClicDroit.Size = new Size(71, 20);
            lblClicDroit.TabIndex = 2;
            lblClicDroit.Text = "Clic Droit";
            // 
            // lblPositionX
            // 
            lblPositionX.AutoSize = true;
            lblPositionX.Location = new Point(550, 18);
            lblPositionX.Name = "lblPositionX";
            lblPositionX.Size = new Size(74, 20);
            lblPositionX.TabIndex = 3;
            lblPositionX.Text = "Position X";
            // 
            // lblPositionY
            // 
            lblPositionY.AutoSize = true;
            lblPositionY.Location = new Point(704, 18);
            lblPositionY.Name = "lblPositionY";
            lblPositionY.Size = new Size(73, 20);
            lblPositionY.TabIndex = 4;
            lblPositionY.Text = "Position Y";
            // 
            // lblClavier
            // 
            lblClavier.AutoSize = true;
            lblClavier.Location = new Point(175, -97);
            lblClavier.Name = "lblClavier";
            lblClavier.Size = new Size(138, 20);
            lblClavier.TabIndex = 5;
            lblClavier.Text = "Interception Clavier";
            // 
            // lsbClavier
            // 
            lsbClavier.FormattingEnabled = true;
            lsbClavier.Location = new Point(12, 58);
            lsbClavier.Name = "lsbClavier";
            lsbClavier.Size = new Size(191, 384);
            lsbClavier.TabIndex = 6;
            lsbClavier.KeyDown += lsbClavier_KeyDown;
            lsbClavier.KeyPress += lsbClavier_KeyPress;
            lsbClavier.KeyUp += lsbClavier_KeyUp;
            // 
            // butRAZ
            // 
            butRAZ.Location = new Point(12, 448);
            butRAZ.Name = "butRAZ";
            butRAZ.Size = new Size(191, 29);
            butRAZ.TabIndex = 7;
            butRAZ.Text = "Remise a zero";
            butRAZ.UseVisualStyleBackColor = true;
            butRAZ.Click += butRAZ_Click;
            // 
            // tbxClicGauche
            // 
            tbxClicGauche.Location = new Point(229, 53);
            tbxClicGauche.Name = "tbxClicGauche";
            tbxClicGauche.Size = new Size(114, 27);
            tbxClicGauche.TabIndex = 8;
            // 
            // tbxClicDroit
            // 
            tbxClicDroit.Location = new Point(397, 53);
            tbxClicDroit.Name = "tbxClicDroit";
            tbxClicDroit.Size = new Size(106, 27);
            tbxClicDroit.TabIndex = 9;
            // 
            // tbxPositionX
            // 
            tbxPositionX.Location = new Point(550, 54);
            tbxPositionX.Name = "tbxPositionX";
            tbxPositionX.ScrollBars = ScrollBars.Vertical;
            tbxPositionX.Size = new Size(107, 27);
            tbxPositionX.TabIndex = 10;
            // 
            // tbxPositionY
            // 
            tbxPositionY.Location = new Point(704, 54);
            tbxPositionY.Name = "tbxPositionY";
            tbxPositionY.Size = new Size(96, 27);
            tbxPositionY.TabIndex = 11;
            // 
            // ecranSourisClavier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 489);
            Controls.Add(tbxPositionY);
            Controls.Add(tbxPositionX);
            Controls.Add(tbxClicDroit);
            Controls.Add(tbxClicGauche);
            Controls.Add(butRAZ);
            Controls.Add(lsbClavier);
            Controls.Add(lblClavier);
            Controls.Add(lblPositionY);
            Controls.Add(lblPositionX);
            Controls.Add(lblClicDroit);
            Controls.Add(lblClicGauche);
            Controls.Add(pnlSouris);
            Name = "ecranSourisClavier";
            Text = "ecranSourisClavier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSouris;
        private Label lblClicGauche;
        private Label lblClicDroit;
        private Label lblPositionX;
        private Label lblPositionY;
        private Label lblClavier;
        private ListBox lsbClavier;
        private Button butRAZ;
        private TextBox tbxClicGauche;
        private TextBox tbxClicDroit;
        private TextBox tbxPositionX;
        private TextBox tbxPositionY;
    }
}