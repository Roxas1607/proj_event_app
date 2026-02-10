using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace proj_event_app
{
    public partial class ecranPermutation : Form
    {

        private bool isImage = true;
        public ecranPermutation()
        {
            InitializeComponent();
        }

        private void bpermutation_Click(object sender, EventArgs e)
        {
            if (isImage)
            {
                pictureBox1.Image = Properties.Resources._3d_printer_300x350;
                pictureBox2.Image = Properties.Resources.vaisseau_alien;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.vaisseau_alien;
                pictureBox2.Image = Properties.Resources._3d_printer_300x350;
            }

            isImage = !isImage;
        }

        private void bNewEcran_Click(object sender, EventArgs e)
        {
            var newForm = new Form();
            
            newForm.FormClosing += (s, args) =>
            {
                DialogResult result = MessageBox.Show(

                "Voulez-vous vraiment fermer la fenêtre ?",
                "Confirmation",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    args.Cancel = true;
                }
                else
                {
                    
                }
            };
            this.Hide();
            newForm.ShowDialog();


        }
       
        


    }

}

