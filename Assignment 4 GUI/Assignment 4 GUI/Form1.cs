namespace Assignment_4_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add ad = new Add();
            {
                ad.Number = txt_number.Text;
                ad.Date = txt_date.Text;
                ad.Invenotrynumber = txt_inventorynumber.Text;
                ad.Objectname = txt_objectname.Text;
                ad.price = txt_price.Text;

                ad.count = txt_count.Text;


                MessageBox.Show("Student has registred successfully");


            };
            ad.save();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}