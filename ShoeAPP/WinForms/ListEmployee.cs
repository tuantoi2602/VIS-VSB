using BusinessLayer.Services;
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
    public partial class ListEmployee : Form
    {
        public ListEmployee()
        {
            InitializeComponent();
            loadDataGridView();
            AddInfoBinding();
        }
        void AddInfoBinding()
        {
            txtEmployee_ID.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Employee_ID", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtAddress.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txtTelephone.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Telephone", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Email", true, DataSourceUpdateMode.Never));

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            this.Hide();
            manager.ShowDialog();
            this.Close();
        }

        private void loadDataGridView()
        {
            dtgv1.DataSource = EmployeeService.Instance.GetEmployees();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            int telephone = Convert.ToInt32(txtTelephone.Text);
            string email = txtEmail.Text;

            if (EmployeeService.Instance.InsertEmployee(name, address, telephone, email))
            {
                MessageBox.Show("Insert successful");
            }
            loadDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            int telephone = Convert.ToInt32(txtTelephone.Text);
            string email = txtEmail.Text;
            int employee_id = Convert.ToInt32(txtEmployee_ID.Text);

            if (EmployeeService.Instance.UpdateEmployee(name, address, telephone, email, employee_id))
            {
                MessageBox.Show("Update successful");
            }
            loadDataGridView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtTelephone.Clear();
            txtEmail.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int employee_id = Convert.ToInt32(txtEmployee_ID.Text);
            if (EmployeeService.Instance.DeleteEmployee(employee_id))
            {
                MessageBox.Show("Delete successful");
            }
            loadDataGridView();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            this.Hide();
            manager.ShowDialog();
            this.Close();
        }
    }
}
