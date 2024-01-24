using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Information shoe = new Information();
            this.Hide();
            shoe.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListManager manager = new ListManager();
            this.Hide();
            manager.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListEmployee employee = new ListEmployee();
            this.Hide();
            employee.ShowDialog();
            this.Close();
        }
    }
}
