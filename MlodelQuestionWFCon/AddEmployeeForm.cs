using ModelQuestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MlodelQuestionWFCon
{
    public partial class AddEmployeeForm : Form
    {
        private bool transportState;
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(
                textBox1.Text,
                textBox2.Text,
                double.Parse(textBox3.Text),
                double.Parse(textBox4.Text),
                transportState
                );

            EmployeeData.EmployeeTable.Add( emp );
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            transportState = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            transportState= false;
        }
    }
}
