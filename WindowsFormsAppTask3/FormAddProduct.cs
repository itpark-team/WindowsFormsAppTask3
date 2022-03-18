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
    public partial class FormAddProduct : Form
    {
        Task3Entities task3Entities = new Task3Entities();

        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            comboBoxProductType.DataSource = null;
            comboBoxProductType.DataSource = task3Entities.ProductTypes.ToList();
            comboBoxProductType.DisplayMember = "Title";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Title = textBoxTitle.Text,
                ArticleNumber = textBoxArticleNumber.Text,
                Description = textBoxDescription.Text,
                Image = textBoxImage.Text,
                ProductionPersonCount = int.Parse(textBoxProductionPersonCount.Text),
                ProductionWorkshopNumber = int.Parse(textBoxProductionWorkshopNumber.Text),
                MinCostForAgent = decimal.Parse(textBoxMinCostForAgent.Text),
                ProductTypeID = ((ProductType)comboBoxProductType.SelectedItem).ID
            };

            task3Entities.Products.Add(product);
            task3Entities.SaveChanges();

            MessageBox.Show("Success add");
        }
    }
}
