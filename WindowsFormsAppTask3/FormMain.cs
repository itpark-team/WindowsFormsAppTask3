using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTask3
{
    public partial class FormMain : Form
    {
        Task3Entities task3Entities = new Task3Entities();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = task3Entities.Products.ToList();

            //dataGridViewProducts.Columns["ProductType"].Visible = false;
            dataGridViewProducts.Columns["Title"].HeaderText = "Название";
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            new FormAddProduct().ShowDialog();
            buttonAddProduct_Click(null, null);
        }

    }
}
