using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategory_add.DataSource = _categoryService.GetAll();
            cbxCategory_add.DisplayMember = "CategoryName";
            cbxCategory_add.ValueMember = "CategoryId";

            cbxCategory_Update.DataSource = _categoryService.GetAll();
            cbxCategory_Update.DisplayMember = "CategoryName";
            cbxCategory_Update.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {
                                
            }
            
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product { 
                CategoryId = Convert.ToInt32(cbxCategory_add.SelectedValue),
                ProductName = tbxProductName_add.Text,
                QuantityPerUnit = tbxQuantity_add.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitprice_Add.Text),
                UnitsInStock = Convert.ToInt16(tbxStock_add.Text)
            });
            MessageBox.Show("Eklendi");
            LoadProducts();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxProductName_Update.Text,
                QuantityPerUnit = tbxQuantity_Update.Text,
                CategoryId = Convert.ToInt32(cbxCategory_Update.SelectedValue),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice_Update.Text),
                UnitsInStock = Convert.ToInt16(tbxStock_Update.Text)

            });
            MessageBox.Show("Güncellendi");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxProductName_Update.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            tbxStock_Update.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
            tbxQuantity_Update.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxUnitPrice_Update.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            cbxCategory_Update.SelectedValue = dgwProduct.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
        }
    }
}
