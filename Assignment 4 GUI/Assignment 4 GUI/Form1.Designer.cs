namespace Assignment_4_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_inventorynumber = new System.Windows.Forms.TextBox();
            this.txt_objectname = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(253, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(515, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(63, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Object name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(63, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(301, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(63, 85);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 23);
            this.txt_number.TabIndex = 6;
            this.txt_number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_inventorynumber
            // 
            this.txt_inventorynumber.Location = new System.Drawing.Point(515, 88);
            this.txt_inventorynumber.Name = "txt_inventorynumber";
            this.txt_inventorynumber.Size = new System.Drawing.Size(210, 23);
            this.txt_inventorynumber.TabIndex = 7;
            // 
            // txt_objectname
            // 
            this.txt_objectname.Location = new System.Drawing.Point(63, 168);
            this.txt_objectname.Name = "txt_objectname";
            this.txt_objectname.Size = new System.Drawing.Size(378, 23);
            this.txt_objectname.TabIndex = 8;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(253, 85);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(200, 23);
            this.txt_date.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(63, 275);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 37);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Location = new System.Drawing.Point(312, 275);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 37);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(63, 230);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(100, 23);
            this.txt_count.TabIndex = 12;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(301, 230);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 23);
            this.txt_price.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_objectname);
            this.Controls.Add(this.txt_inventorynumber);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_number;
        private TextBox txt_inventorynumber;
        private TextBox txt_objectname;
        private DateTimePicker txt_date;
        private Button btn_add;
        private Button btn_cancel;
        private TextBox txt_count;
        private TextBox txt_price;
    }
}