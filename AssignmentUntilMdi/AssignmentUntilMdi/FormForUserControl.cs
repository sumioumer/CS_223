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
    public partial class FormForUserControl : Form
    {
        public FormForUserControl()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Formforusercontrol_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in Product.GetAll())
            {
                CustomCard customCard = new CustomCard();
                customCard.Title = item.ToString();
                customCard.Description = item.ToString();
                customCard.Price = item.ToString();
                flowLayoutPanel1.Controls.Add(customCard);
            }
        }
    }
}
