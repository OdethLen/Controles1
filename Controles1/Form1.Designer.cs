namespace Controles1
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
            components = new System.ComponentModel.Container();
            btnAdd = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            checkBox3 = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            msktxtNumber = new MaskedTextBox();
            label6 = new Label();
            monthCalendar1 = new MonthCalendar();
            label5 = new Label();
            dateTimePicker = new DateTimePicker();
            notifyIcon1 = new NotifyIcon(components);
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            progressBar1 = new ProgressBar();
            rbSlytherin = new RadioButton();
            rbGryffindor = new RadioButton();
            rbHufflepuff = new RadioButton();
            rbRavenclaw = new RadioButton();
            richTextBox1 = new RichTextBox();
            txtName = new TextBox();
            toolTip1 = new ToolTip(components);
            treeView1 = new TreeView();
            listBox2 = new ListBox();
            label8 = new Label();
            btnProgress = new Button();
            button1 = new Button();
            lblHouse = new Label();
            button2 = new Button();
            lblName = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            btnPrintnum = new Button();
            lblNumber = new Label();
            lblBirthdate = new Label();
            button4 = new Button();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(41, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Button";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(27, 81);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(49, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Cats";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(27, 106);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(53, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Dogs";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 3;
            label1.Text = "What type of pets do you have?";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(27, 131);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(65, 19);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Rabbits";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Oil", "Apple", "Milk", "Eggs", "Jouice", "Flour", "Toilet paper ", "Orange", "Honey", "Bannana", "Cereal", "Strawberry", "Lemon", "Avocado" });
            checkedListBox1.Location = new Point(27, 186);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 5;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 109);
            label2.Name = "label2";
            label2.Size = new Size(173, 15);
            label2.TabIndex = 6;
            label2.Text = "Which is your Hogwarts house?";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Elementary School", "Middle School", "High School", "College" });
            comboBox1.Location = new Point(12, 322);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 303);
            label3.Name = "label3";
            label3.Size = new Size(158, 15);
            label3.TabIndex = 8;
            label3.Text = "Select your degree of studies";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 9;
            label4.Text = "Shopping list";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel1.Location = new Point(553, 12);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 15);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "SunFlower";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(206, 168);
            listView1.Name = "listView1";
            listView1.Size = new Size(142, 56);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            // 
            // msktxtNumber
            // 
            msktxtNumber.Location = new Point(305, 230);
            msktxtNumber.Mask = "99999";
            msktxtNumber.Name = "msktxtNumber";
            msktxtNumber.Size = new Size(100, 23);
            msktxtNumber.TabIndex = 15;
            msktxtNumber.ValidatingType = typeof(int);
            msktxtNumber.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(207, 238);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 16;
            label6.Text = "Write a number:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(195, 303);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 381);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 19;
            label5.Text = " Birth date:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(73, 375);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(97, 23);
            dateTimePicker.TabIndex = 18;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(369, 27);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(369, 9);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 21;
            label7.Text = "Select your average";
            label7.Click += label7_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(369, 63);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(151, 23);
            progressBar1.TabIndex = 23;
            progressBar1.Click += progressBar1_Click;
            // 
            // rbSlytherin
            // 
            rbSlytherin.AutoSize = true;
            rbSlytherin.Location = new Point(374, 150);
            rbSlytherin.Name = "rbSlytherin";
            rbSlytherin.Size = new Size(74, 19);
            rbSlytherin.TabIndex = 24;
            rbSlytherin.TabStop = true;
            rbSlytherin.Text = "Slytherin ";
            rbSlytherin.UseVisualStyleBackColor = true;
            // 
            // rbGryffindor
            // 
            rbGryffindor.AutoSize = true;
            rbGryffindor.Location = new Point(374, 127);
            rbGryffindor.Name = "rbGryffindor";
            rbGryffindor.Size = new Size(79, 19);
            rbGryffindor.TabIndex = 25;
            rbGryffindor.TabStop = true;
            rbGryffindor.Text = "Gryffindor";
            rbGryffindor.UseVisualStyleBackColor = true;
            // 
            // rbHufflepuff
            // 
            rbHufflepuff.AutoSize = true;
            rbHufflepuff.Location = new Point(455, 127);
            rbHufflepuff.Name = "rbHufflepuff";
            rbHufflepuff.Size = new Size(80, 19);
            rbHufflepuff.TabIndex = 26;
            rbHufflepuff.TabStop = true;
            rbHufflepuff.Text = "Hufflepuff";
            rbHufflepuff.UseVisualStyleBackColor = true;
            // 
            // rbRavenclaw
            // 
            rbRavenclaw.AutoSize = true;
            rbRavenclaw.Location = new Point(455, 150);
            rbRavenclaw.Name = "rbRavenclaw";
            rbRavenclaw.Size = new Size(81, 19);
            rbRavenclaw.TabIndex = 27;
            rbRavenclaw.TabStop = true;
            rbRavenclaw.Text = "Ravenclaw";
            rbRavenclaw.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(455, 252);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(183, 144);
            richTextBox1.TabIndex = 28;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(512, 406);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 23);
            txtName.TabIndex = 29;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(644, 252);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(121, 97);
            treeView1.TabIndex = 30;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            listBox2.Location = new Point(207, 27);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(464, 409);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 32;
            label8.Text = "Name:";
            // 
            // btnProgress
            // 
            btnProgress.Location = new Point(526, 63);
            btnProgress.Name = "btnProgress";
            btnProgress.Size = new Size(75, 23);
            btnProgress.TabIndex = 33;
            btnProgress.Text = "Progress";
            btnProgress.UseVisualStyleBackColor = true;
            btnProgress.Click += btnProgress_Click;
            // 
            // button1
            // 
            button1.Location = new Point(607, 63);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 34;
            button1.Text = "Setback";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lblHouse
            // 
            lblHouse.AutoSize = true;
            lblHouse.Location = new Point(563, 132);
            lblHouse.Name = "lblHouse";
            lblHouse.Size = new Size(16, 15);
            lblHouse.TabIndex = 35;
            lblHouse.Text = "...";
            // 
            // button2
            // 
            button2.Location = new Point(553, 109);
            button2.Name = "button2";
            button2.Size = new Size(77, 20);
            button2.TabIndex = 36;
            button2.Text = "Choose";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(492, 433);
            lblName.Name = "lblName";
            lblName.Size = new Size(16, 15);
            lblName.TabIndex = 37;
            lblName.Text = "...";
            // 
            // button3
            // 
            button3.Location = new Point(655, 409);
            button3.Name = "button3";
            button3.Size = new Size(75, 20);
            button3.TabIndex = 38;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._09ebf8a5039ca1843990a3fb12e2c30f;
            pictureBox1.Location = new Point(708, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 192);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // btnPrintnum
            // 
            btnPrintnum.Location = new Point(330, 259);
            btnPrintnum.Name = "btnPrintnum";
            btnPrintnum.Size = new Size(75, 23);
            btnPrintnum.TabIndex = 40;
            btnPrintnum.Text = "Print";
            btnPrintnum.UseVisualStyleBackColor = true;
            btnPrintnum.Click += btnNumber_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(207, 263);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(16, 15);
            lblNumber.TabIndex = 41;
            lblNumber.Text = "...";
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.Location = new Point(12, 406);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(16, 15);
            lblBirthdate.TabIndex = 42;
            lblBirthdate.Text = "...";
            // 
            // button4
            // 
            button4.Location = new Point(95, 425);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 43;
            button4.Text = "Print date";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(206, 9);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 44;
            label9.Text = "Choose a number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(207, 127);
            label10.Name = "label10";
            label10.Size = new Size(16, 15);
            label10.TabIndex = 45;
            label10.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 472);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(lblBirthdate);
            Controls.Add(lblNumber);
            Controls.Add(btnPrintnum);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(lblName);
            Controls.Add(button2);
            Controls.Add(lblHouse);
            Controls.Add(button1);
            Controls.Add(btnProgress);
            Controls.Add(label8);
            Controls.Add(listBox2);
            Controls.Add(treeView1);
            Controls.Add(txtName);
            Controls.Add(richTextBox1);
            Controls.Add(rbRavenclaw);
            Controls.Add(rbHufflepuff);
            Controls.Add(rbGryffindor);
            Controls.Add(rbSlytherin);
            Controls.Add(progressBar1);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker);
            Controls.Add(monthCalendar1);
            Controls.Add(label6);
            Controls.Add(msktxtNumber);
            Controls.Add(listView1);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox3);
            Controls.Add(label1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private CheckBox checkBox3;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private MaskedTextBox msktxtNumber;
        private Label label6;
        private MonthCalendar monthCalendar1;
        private Label label5;
        private DateTimePicker dateTimePicker;
        private NotifyIcon notifyIcon1;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private ProgressBar progressBar1;
        private RadioButton rbSlytherin;
        private RadioButton rbGryffindor;
        private RadioButton rbHufflepuff;
        private RadioButton rbRavenclaw;
        private RichTextBox richTextBox1;
        private TextBox txtName;
        private ToolTip toolTip1;
        private TreeView treeView1;
        private ListBox listBox2;
        private Label label8;
        private Button btnProgress;
        private Button button1;
        private Label lblHouse;
        private Button button2;
        private Label lblName;
        private Button button3;
        private PictureBox pictureBox1;
        private Button btnPrintnum;
        private Label lblNumber;
        private Label lblBirthdate;
        private Button button4;
        private Label label9;
        private Label label10;
    }
}
