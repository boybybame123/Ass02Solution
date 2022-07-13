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
    public partial class frmProducts : Form
    {
        public Member Emails { get; set; }

        public bool adminOrMembers { get; set; }
        BindingSource source;

        IProduct pros = new ProductRepository();

        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetsProductObject();
                pros.DeleteProduct(member);
                loadListProduct();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a Member");
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {




        }
        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetail fr = new frmProductDetail()
            {
                Text = " update",
                UpdateOrInsert = true,
                pro = GetsProductObject(),
                product = pros
            };
            if (fr.ShowDialog() == DialogResult.OK)
            {
                loadListProduct();

            }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {

        }
        public void loadListSearching(string search)
        {


            var member = pros.Searching(search);
            try
            {
                source = new BindingSource();
                source.DataSource = member;

                txtProductId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();


                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");


                dgvProducts.DataSource = null;
                dgvProducts.DataSource = source;

                if (member.Count() == 0)
                {
                    clearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member List");
            }

        }
        public void loadListSearch(int search)
        {


            var member = pros.Search(search);
            try
            {
                source = new BindingSource();
                source.DataSource = member;

                txtProductId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = source;
                if (member.Count() == 0)
                {
                    clearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }

        }
        public void loadListSearchUnitprice(decimal search)
        {


            var member = pros.SearchUnitPrice(search);
            try
            {
                source = new BindingSource();
                source.DataSource = member;
                txtProductId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = source;
                if (member.Count() == 0)
                {
                    clearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member List");
            }

        }
        public void loadListProduct()
        {


            var member = pros.GetAllProducts();
            try
            {
                source = new BindingSource();
                source.DataSource = member;

                txtProductId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = source;
                if (member.Count() == 0)
                {
                    clearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member" +
                    " List");
            }

        }


        private void clearText()
        {
            txtProductId.Text = String.Empty;
            txtCategoryId.Text = String.Empty;
            txtProductName.Text = String.Empty;
            txtWeight.Text = String.Empty;
            txtUnitPrice.Text = String.Empty;
            txtUnitsInStock.Text = String.Empty;

        }
        private Product GetsProductObject()
        {
            Product product = null;
            try
            {

                product = new Product()
                {
                    ProductId = int.Parse(txtProductId.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),

                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member!!!");

            }
            return product;

        }



        private void btnRead_Click_1(object sender, EventArgs e)
        {

            loadListProduct();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            frmProductDetail fr = new frmProductDetail()
            {
                Text = "Add product",
                UpdateOrInsert = false,
                product = pros
            };
            if (fr.ShowDialog() == DialogResult.OK)
            {
                loadListProduct();
                source.Position = source.Count - 1;
            }



        }

        private void btnSearching_Click(object sender, EventArgs e)
        {
            try
            {

                decimal info = decimal.Parse(txtSearchUnitPrice.Text);
                loadListSearchUnitprice(info);
                txtSearchUnitPrice.Text = String.Empty;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnSearchIDProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int info = int.Parse(txtSearch.Text);
                loadListSearch(info);
                txtSearch.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNameProduct_Click(object sender, EventArgs e)
        {

            try
            {
                string info = txtSearching.Text;
                loadListSearching(info);
                txtSearching.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


       





        