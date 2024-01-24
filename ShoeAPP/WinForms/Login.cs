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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            if (login == "admin")
            {
                Manager manager = new Manager();
                this.Hide();
                manager.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hey! You are not admin", "Who are you?");

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Goobye.", "Closed!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }
    }
}
