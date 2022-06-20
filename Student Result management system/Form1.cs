using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Result_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit =MessageBox.Show("Confirm if you want to exit","Student Ranking",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ;
            

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);

        }

 



        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //comboBox1.Items.Add("19lc computer tech");
            //comboBox1.Items.Add("18lc Softwork");
            //comboBox1.Items.Add("18lc CST");

        }







        private void button7_Click(object sender, EventArgs e)
        {
            double[] R = new double[14];

            R[0] = Convert.ToDouble(textBox8.Text);
            R[1] = Convert.ToDouble(textBox9.Text);
            R[2] = Convert.ToDouble(textBox10.Text);

            R[3] = R[0] + R[1] + R[2];
            //R[4] = (R[3] / 3);

            //string av = Convert.ToString(R[4]);
            string Tt = Convert.ToString(R[3]);

            //textBox11.Text = Tt;
            //textBox12.Text = av;

            if (R[0]<60 |  R[1]<60 | R[2]<60)
            {
                textBox22.Text = textBox2.Text+" " + textBox3.Text;
                if (R[0] < 60)
                {
                    textBox21.Text = textBox21.Text + " "+ "English,";
                }
                if (R[1] < 60)
                {
                    textBox21.Text = textBox21.Text + " " + "Mathematics,";
                }
                if (R[2] < 60)
                {
                    textBox21.Text = textBox21.Text + " " + "Computer,";
                }

            }
             if(R[0]>=80 & R[1] >= 80 & R[2] >= 80 & R[3] >= 260)

            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text,  textBox8.Text,
                    textBox9.Text, textBox10.Text , Tt ,"PASSED");
            }


        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }





        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
