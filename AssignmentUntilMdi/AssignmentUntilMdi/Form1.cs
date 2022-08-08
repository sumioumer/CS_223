using System;
using System.Text.RegularExpressions;
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
    public partial class Form1 : Form
    {
        public string username { get; set; }
        /*public Form1()
        {
            InitializeComponent();
        }*/
       public Form1(string user)
        {
            InitializeComponent();
            label8.Text = user;
        }
       
        private void btn_Add_Click(object sender, EventArgs e)
        {


            Product md = new Product();
            {
                md.Number = txt_number.Text;
                md.date = txt_date.Text;
                md.inventorynumber = txt_inventorynumber.Text;
                md.objectname = txt_objectname.Text;
                md.price = txt_price.Text;
                md.count = txt_count.Text;
                checkedListBox1.CheckedItems.Contains(md);
                String message = " ";
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    message += item.ToString();
                }
                //  MessageBox.Show(message);

            }
            md.save();
            if (string.IsNullOrEmpty(txt_number.Text))
            {
                errorProvider1.SetError(txt_number, "Number is required");
            }
            /* else
             { errorProvider1.Clear(); }
            */

            if (txt_objectname.Text.Length < 3)
            {
                errorProvider1.SetError(txt_objectname, "Miniumum ");
            }
            Regex regex = new Regex(@"^[a-z] { 2}$");
            if (regex.IsMatch(txt_objectname.Text))
            {

            }
            else
            {
                // MessageBox.Show("Hmmm");
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Product.GetAll();
            MessageBox.Show("Item Added");





            /* string number=txt_number.Text;
             string date= txt_date.Text;
             string inventory_number=txt_inventorynumber.Text;
             string object_name=txt_objectname.Text;
             string count=txt_count.Text;
             string price=txt_price.Text;
             MessageBox.Show("Item Added");*/


            /*public Main()
            {
            }*/
        }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void txt_buttonclick1_Click(object sender, EventArgs e)
            {


            }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
