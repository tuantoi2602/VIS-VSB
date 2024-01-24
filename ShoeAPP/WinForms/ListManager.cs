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
    public partial class ListManager : Form
    {
        public ListManager()
        {
            InitializeComponent();
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            dtgv1.DataSource = ManagerService.Instance.ReadDataManager();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            this.Hide();
            manager.ShowDialog();
            this.Close();
        }
    }
}
