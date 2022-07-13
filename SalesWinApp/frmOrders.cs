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
    public partial class frmOrders : Form
    {
        public Member Email { get; set; }
        public Order orders { get; set; }
        public OrderDetail orderDetails { get; set; }

        public bool adminsOrMember { get; set; }
        IOrderDetail prose = new OrderDetailRepository();
        BindingSource source;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            if (adminsOrMember == false)
            {
                btnDelete.Enabled = false;  
               
            }
            
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
          
            if(adminsOrMember== true) {
                loadListOrđer();
            }
            else
            {
                loadListOrderbyMember(Email);
            }
            
        }
        public void loadListOrđer()                      
        {

            
            var member = prose.SearchOrder();
           


            try
            {
                source = new BindingSource();  
                source.DataSource = member; 

                txtProductId.DataBindings.Clear();
                txtMemberId.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtOrderId.DataBindings.Clear();

               
                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");
                txtDiscount.DataBindings.Add("Text", source, "Discount");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtOrderId.DataBindings.Add("Text", source, "OrderId");
            

                DgvOrder.DataSource = null;
                
                DgvOrder.DataSource = source;
           
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
        public void loadListOrderbyMember(Member a)
        { 

            var p = a.MemberId;
            var member = prose.SearchOrderdetails(p);



            try
            {
                source = new BindingSource(); 
                source.DataSource = member; 

                txtProductId.DataBindings.Clear();
                txtMemberId.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtOrderId.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");
                txtDiscount.DataBindings.Add("Text", source, "Discount");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtOrderId.DataBindings.Add("Text", source, "OrderId");
           

                DgvOrder.DataSource = null;

                DgvOrder.DataSource = source;
            
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

        private void clearText()
        {
            txtProductId.Text = String.Empty;
            txtMemberId.Text = String.Empty;
            txtOrderDate.Text = String.Empty;
            txtFreight.Text = String.Empty;
            txtDiscount.Text = String.Empty;
            txtQuantity.Text = String.Empty;
            txtRequiredDate.Text = String.Empty;
            txtShippedDate.Text = String.Empty;
            txtUnitPrice.Text = String.Empty;
            txtOrderId.Text = String.Empty;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmOrdersDetail detail = new frmOrdersDetail()
            {
                Text = "Add Order ",
                UpdateOrInsert = false,
                order = GetsOrderObjects(),
                orderDetail = GetsOrderDetailObjects(),
                OrderDetailRespository = prose

            };
            if (detail.ShowDialog() == DialogResult.OK)
            {
                loadListOrđer();
            }

        }
        private Order GetsOrderObjects()
        {
            Order order = null;
            try
            {
                order = new Order()
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text),


                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member!!!");

            }
           return order;

        }
        private OrderDetail GetsOrderDetailObjects()
        {
            OrderDetail order = null;
            try
            {
                order = new OrderDetail()
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    ProductId = int.Parse(txtProductId.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = double.Parse(txtQuantity.Text),


                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member!!!");

            }
            return order;

        }

        private void DgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                orderDetails = GetsOrderDetailObjects();
                orders = GetsOrderObjects();
                prose.DeleteOrderDetail(orderDetails, orders);
                loadListOrđer();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a Member");
            }
        }

        private void txtReport_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport()
            {
                Text = "Report",
                orderDetails = GetsOrderDetailObjects(),
                orders = GetsOrderObjects(),
                EmailforReport = Email,
                adminsOrMembers = adminsOrMember
            };
            report.ShowDialog();
            MessageBox.Show("okkk");
        }
    }
}
