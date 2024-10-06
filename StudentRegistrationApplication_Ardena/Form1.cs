using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication_Ardena
{
    public partial class Form1 : Form
    {
        string gender;
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastname = textBox1.Text;
            string firstname = textBox2.Text;
            string middlename = textBox3.Text;

            radioButton1.Checked = true;
            radioButton2.Checked = true;

            var date = comboBox1.SelectedItem;
            var month = comboBox2.SelectedItem;
            var year = comboBox3.SelectedItem;

            


            complete(lastname,firstname,middlename);


        }

        public void complete(string ln ,string fn, string mn)
        {
            var date = comboBox1.SelectedItem;
            var month = comboBox2.SelectedItem;
            var year = comboBox3.SelectedItem;
            var program = comboBox4.SelectedItem;
            MessageBox.Show("Last Name: " + ln + "\n" + "First Name: " + fn + "\n" + "Middle Name: " + mn + "\n" +
               "gender: "  + gender + "\n" +
               "Date of Birth: " + date + "," + month + "," + year +
               "\n" + "Program: " + program);

        }

        public void complete(string fn, string mn)
        {
            var date = comboBox1.SelectedItem;
            var month = comboBox2.SelectedItem;
            var year = comboBox3.SelectedItem;
            var program = comboBox4.SelectedItem;
            MessageBox.Show("Last Name: " + "\n" + "First Name: " + fn + "\n" + "Middle Name: " + mn + "\n" +
               "gender: " + gender + "\n" +
               "Date of Birth: " + date + "," + month + "," + year +
               "\n" + "Program: " + program);

        }

        public void complete(string mn)
        {
            var date = comboBox1.SelectedItem;
            var month = comboBox2.SelectedItem;
            var year = comboBox3.SelectedItem;
            var program = comboBox4.SelectedItem;
            MessageBox.Show("Last Name: "  + "\n" + "First Name: "  + "\n" + "Middle Name: " + mn + "\n" +
               "gender: " + gender + "\n" +
               "Date of Birth: " + date + "," + month + "," + year +
               "\n" + "Program: " + program);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";

        }
    }
}
