﻿namespace Assignment4_on_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
     /*   protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_inventorynumber = new System.Windows.Forms.TextBox();
            this.txt_objectname = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_buttonclick2 = new System.Windows.Forms.Button();
            this.txt_buttonclick1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.gridview_register = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
           // this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Object name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Count";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(36, 71);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(179, 26);
            this.txt_number.TabIndex = 7;
            // 
            // txt_inventorynumber
            // 
            this.txt_inventorynumber.Location = new System.Drawing.Point(591, 71);
            this.txt_inventorynumber.Name = "txt_inventorynumber";
            this.txt_inventorynumber.Size = new System.Drawing.Size(189, 26);
            this.txt_inventorynumber.TabIndex = 8;
            // 
            // txt_objectname
            // 
            this.txt_objectname.Location = new System.Drawing.Point(35, 166);
            this.txt_objectname.Name = "txt_objectname";
            this.txt_objectname.Size = new System.Drawing.Size(745, 26);
            this.txt_objectname.TabIndex = 9;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(275, 278);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 26);
            this.txt_price.TabIndex = 10;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(35, 278);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(180, 26);
            this.txt_count.TabIndex = 11;
            // 
            // txt_buttonclick2
            // 
            this.txt_buttonclick2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buttonclick2.Location = new System.Drawing.Point(406, 337);
            this.txt_buttonclick2.Name = "txt_buttonclick2";
            this.txt_buttonclick2.Size = new System.Drawing.Size(123, 32);
            this.txt_buttonclick2.TabIndex = 12;
            this.txt_buttonclick2.Text = "Cancel";
            this.txt_buttonclick2.UseVisualStyleBackColor = true;
            //this.txt_buttonclick2.Click += new System.EventHandler(this.txt_buttonclick2_Click);
            // 
            // txt_buttonclick1
            // 
            this.txt_buttonclick1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buttonclick1.Location = new System.Drawing.Point(24, 337);
            this.txt_buttonclick1.Name = "txt_buttonclick1";
            this.txt_buttonclick1.Size = new System.Drawing.Size(224, 31);
            this.txt_buttonclick1.TabIndex = 13;
            this.txt_buttonclick1.Text = "Add";
            this.txt_buttonclick1.UseVisualStyleBackColor = true;
          //  this.txt_buttonclick1.Click += new System.EventHandler(this.txt_buttonclick1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(243, 71);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(260, 26);
            this.txt_date.TabIndex = 14;
            // 
            // gridview_register
            // 
            this.gridview_register.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_register.Location = new System.Drawing.Point(24, 416);
            this.gridview_register.Name = "gridview_register";
            this.gridview_register.RowHeadersWidth = 62;
            this.gridview_register.RowTemplate.Height = 28;
            this.gridview_register.Size = new System.Drawing.Size(851, 181);
            this.gridview_register.TabIndex = 15;
            //this.gridview_register.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_register_CellContentClick);
            // 
            // errorProvider1
            // 
           // this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
           /* this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 624);
            this.Controls.Add(this.gridview_register);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_buttonclick1);
            this.Controls.Add(this.txt_buttonclick2);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_price);
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
            this.Text = "Add Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();*/
            //this.ResumeLayout(false);
            //this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_inventorynumber;
        private System.Windows.Forms.TextBox txt_objectname;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Button txt_buttonclick2;
        private System.Windows.Forms.Button txt_buttonclick1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.DataGridView gridview_register;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}