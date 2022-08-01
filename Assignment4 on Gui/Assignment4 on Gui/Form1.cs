namespace Assignment4_on_Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CheckBox checkBox1;

        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chk_List = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.variable = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(253, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk_List
            // 
            this.chk_List.FormattingEnabled = true;
            this.chk_List.Items.AddRange(new object[] {
            "Is regular",
            "Is unique",
            "Is Null"});
            this.chk_List.Location = new System.Drawing.Point(458, 27);
            this.chk_List.Name = "chk_List";
            this.chk_List.Size = new System.Drawing.Size(120, 94);
            this.chk_List.TabIndex = 1;
            this.chk_List.SelectedIndexChanged += new System.EventHandler(this.chk_List_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Simple";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // variable
            // 
            this.variable.AutoSize = true;
            this.variable.Location = new System.Drawing.Point(6, 47);
            this.variable.Name = "variable";
            this.variable.Size = new System.Drawing.Size(66, 19);
            this.variable.TabIndex = 4;
            this.variable.TabStop = true;
            this.variable.Text = "variable";
            this.variable.UseVisualStyleBackColor = true;
            this.variable.CheckedChanged += new System.EventHandler(this.variable_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.variable);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 134);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(740, 300);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chk_List);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private CheckedListBox chk_List;
        private Button button1;
        private RadioButton radioButton1;

        private void button1_Click(object sender, EventArgs e)
        {

            string message = "";
            foreach( var item in chk_List.CheckedItems)
            {
                message += item.ToString(); 
            }
            MessageBox.Show(message);
        }

        private void chk_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private RadioButton variable;

        private void variable_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Variable");
        }

        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton radioButton2;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("simple");
        }
    }
}