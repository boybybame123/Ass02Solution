using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetail : Form
    {
        public Product pro { get; set; }
        public IProduct product { get; set; }
        public bool UpdateOrInsert { get; set; }
        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            txtProductId.Enabled = !UpdateOrInsert;


            if (UpdateOrInsert == true)
            {
                txtCategoryId.Text = pro.CategoryId.ToString();
                txtProductId.Text = pro.ProductId.ToString();
                txtProductName.Text = pro.ProductName.ToString();
                txtUnitPrice.Text = pro.UnitPrice.ToString();
                txtUnitsInStock.Text = pro.UnitsInStock.ToString();
                txtWeight.Text = pro.Weight.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var mem = new Product()
                {
                    ProductId = int.Parse(txtProductId.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                    

                };
                if (UpdateOrInsert == true)
                {
                    product.UpdateProduct(mem);
                   
                    
                }
                else
                {
                    product.SaveProduct(mem);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, UpdateOrInsert == true?"fail update": "fail insert");

            }
           
        }
    }
}
