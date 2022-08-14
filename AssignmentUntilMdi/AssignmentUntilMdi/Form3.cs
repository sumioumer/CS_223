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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Indicator_Paint(object sender, PaintEventArgs e)
        {
            Indicator.Top = 60;
panel2.Visible=false; 
        }
    }
}
