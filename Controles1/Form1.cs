using System.Diagnostics;
namespace Controles1
{
    public partial class Form1 : Form
    {

        int progress; //Variable de proogres bar 


        public Form1()
        {
            InitializeComponent();
            progress = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked!!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnProgress_Click(object sender, EventArgs e) //Progress bar 
        {
            if (progress >= 0 && progress <= 90) //It is a component used to monitor the progress of an operation.
            {
                progress += 10;
                progressBar1.Value = progress;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (progress > 0 && progress <= 100)
            {
                progress -= 10;
                progressBar1.Value = progress;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Utiliza un switch para determinar la elección
            switch (true)
            {
                case true when rbGryffindor.Checked:
                    lblHouse.Text = "¡Welcome to Gryffindor!";
                    break;
                case true when rbHufflepuff.Checked:
                    lblHouse.Text = "¡Welcome to Hufflepuff!";
                    break;
                case true when rbRavenclaw.Checked:
                    lblHouse.Text = "¡Welcome to RavenClaw!";
                    break;
                case true when rbSlytherin.Checked:
                    lblHouse.Text = "¡Welcome to Slytherin!";
                    break;
            }

            //Switch de casas y agregar mensaje en el lbl de la elección
            //switch ()
            //{
            //    case rbGryffindor.Checked==true:
            //        break;
            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblName.Text = "Your name is " + txtName.Text;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            lblNumber.Text = msktxtNumber.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblBirthdate.Text="You born in "+dateTimePicker.Text;
        }
    }
}
