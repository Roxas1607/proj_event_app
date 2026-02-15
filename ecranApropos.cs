using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_event_app
{
    public partial class ecranApropos : Form
    {
        private Cursor newCursor;
        public ecranApropos()
        {
            InitializeComponent();
        }

        private void lVersion_Click(object sender, EventArgs e)
        {

        }

        private void lText_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            newCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

            this.Cursor = newCursor;
        }

    }
}
