using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        //table
        DataTable table = new DataTable("Table");
       public List<employee> Employees {  get; set; }

        public Form1()
        {
            
            InitializeComponent();
        }
 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string id = textBox1.Text;
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string position = textBox4.Text;

            //class
            employee em = new employee(id, firstName,lastName,position);

           //constructor
            table.Rows.Add(em.EmployeeID,em.FirstName,em.Surname,em.Position);

            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //default name of data grid view
            table.Columns.Add("EmployeeID", Type.GetType("System.String"));
            table.Columns.Add("firstname", Type.GetType("System.String"));
            table.Columns.Add("lastname", Type.GetType("System.String"));
            table.Columns.Add("Position", Type.GetType("System.String"));
            dataGridView1.DataSource = table;
        }
    }
}
