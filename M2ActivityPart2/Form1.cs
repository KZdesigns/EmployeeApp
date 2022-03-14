using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2ActivityPart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create 3 employee object with specified data
            Employee employee1 = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");
            Employee employee2 = new Employee("Mark Jones", 39119, "IT", "Programmer");
            Employee employee3 = new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer");

            // Add the object data to the correspoding text boxes
            name1TextBox.Text = employee1.Name;
            id1TextBox.Text = employee1.IdNumber.ToString();
            dep1TextBox.Text = employee1.Department;
            pos1TextBox.Text = employee1.Position;

            name2TextBox.Text = employee2.Name;
            id2TextBox.Text = employee2.IdNumber.ToString();
            dep2TextBox.Text = employee2.Department;
            pos2TextBox.Text = employee2.Position;

            name3TextBox.Text = employee3.Name;
            id3TextBox.Text = employee3.IdNumber.ToString();
            dep3TextBox.Text = employee3.Department;
            pos3TextBox.Text = employee3.Position;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Close Application Button
            this.Close();
        }
    }
}
