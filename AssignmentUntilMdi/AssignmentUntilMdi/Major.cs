using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentUntilMdi
{
    public partial class Major : Form
    {
        public Major()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


            Form1 display = new Form1("Ahlam");
            display.MdiParent = this;
            display.Show();
        }

        private void dislayAllProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


            Form2 display = new Form2();
            display.MdiParent = this;
            display.Show();
        }

        private void searchItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


            Search display = new Search();
            display.MdiParent = this;
            display.Show();

        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
