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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
            loadDataGridView();
            AddInfoBinding();
        }
        void AddInfoBinding()
        {
            txtShoe_ID.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Shoe_id", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtSize.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Size", true, DataSourceUpdateMode.Never));
            txtDescription.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Description", true, DataSourceUpdateMode.Never));
            txtPrice.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Price", true, DataSourceUpdateMode.Never));
            txtCustomer_ID.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Customer_id", true, DataSourceUpdateMode.Never));
            txtBrand_ID.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Brand_id", true, DataSourceUpdateMode.Never));
            txtSupplier_ID.DataBindings.Add(new Binding("Text", dtgv1.DataSource, "Supplier_id", true, DataSourceUpdateMode.Never));

        }
        private void dtgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void loadDataGridView()
        {
            dtgv1.DataSource = ShoeService.Instance.GetShoeList();
        }

        private void button1_Click(object sender, EventArgs e) //Insert
        {
            string name = txtName.Text;
            int size = Convert.ToInt32(txtSize.Text);
            string description = txtDescription.Text;
            int price = Convert.ToInt32(txtPrice.Text);
            int customer_id = Convert.ToInt32(txtCustomer_ID.Text);
            int brand_id = Convert.ToInt32(txtBrand_ID.Text);
            int supplier_id = Convert.ToInt32(txtSupplier_ID.Text);

            if (ShoeService.Instance.InsertShoe(name, size, description, price, customer_id, brand_id, supplier_id))
            {
                MessageBox.Show("Insert successful");
            }
            loadDataGridView();
        }

        private void button3_Click(object sender, EventArgs e) //Update
        {
            string name = txtName.Text;
            int size = Convert.ToInt32(txtSize.Text);
            string description = txtDescription.Text;
            int price = Convert.ToInt32(txtPrice.Text);
            int customer_id = Convert.ToInt32(txtCustomer_ID.Text);
            int brand_id = Convert.ToInt32(txtBrand_ID.Text);
            int supplier_id = Convert.ToInt32(txtSupplier_ID.Text);
            int shoe_id = Convert.ToInt32(txtShoe_ID.Text);

            if (ShoeService.Instance.UpdateShoe(name, size, description, price, customer_id, brand_id, supplier_id, shoe_id))
            {
                MessageBox.Show("Update successful");
            }
            loadDataGridView();
        }

        private void button4_Click(object sender, EventArgs e) // Delete
        {
            int shoe_id = Convert.ToInt32(txtShoe_ID.Text);
            if (MessageBox.Show("Are you sure?", "Remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ShoeService.Instance.DeleteShoe(shoe_id);
            }
            loadDataGridView();
        }

        private void button5_Click(object sender, EventArgs e) // Clear all
        {
            txtName.Clear();
            txtSize.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtCustomer_ID.Clear();
            txtBrand_ID.Clear();
            txtSupplier_ID.Clear();
            txtShoe_ID.Clear();
        }

        private void button2_Click(object sender, EventArgs e) // Back to Admin Page
        {
            Manager manager = new Manager();
            this.Hide();
            manager.ShowDialog();
            this.Close();
        }
    }
}
