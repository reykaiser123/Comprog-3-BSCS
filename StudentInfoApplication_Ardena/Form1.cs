using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication_Ardena
{
    public partial class Form1 : Form
    {
        string studentid = string.Empty;
        string firstname = string.Empty;
        string lastname = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void studentInfo()
        {
            string student = textBox1.Text;
            string fn = textBox2.Text;
            string ln = textBox3.Text;

            setstudentid(student);
            setfirstname(fn);
            setlastname(ln);

        }
        public void setstudentid(string sid)
        {
            this.studentid = sid;
            
        }

        public void setfirstname(string sfn)
        {
            this.firstname = sfn;
            
        }

        public void setlastname(string sln)
        {
            this.lastname = sln;
            
        }

        public string getstudentid()
        {
            return this.studentid;
        }

        public string getfirstname()
        {
            return this.firstname;
        }

        public string getlastname()
        {
            return this.lastname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentInfo();

            listBox1.Items.Add(getstudentid());
            listBox2.Items.Add(getfirstname());
            listBox3.Items.Add(getlastname());
        }
    }
}

