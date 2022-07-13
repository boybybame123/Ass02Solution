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
    public partial class frmOrdersDetail : Form
    {
        public IOrderDetail OrderDetailRespository { get; set; }

        public bool UpdateOrInsert { get; set; }
        public Order order { get; set; }
        public OrderDetail orderDetail { get; set; }
        public frmOrdersDetail()
        {
            InitializeComponent();
        }

        private void frmOrdersDetail_Load(object sender, EventArgs e)
        {
            txtMemberId.Enabled = false;
            txtMemberId.Enabled = !UpdateOrInsert;
            if (UpdateOrInsert == true)
            {
                txtOrderId.Text = orderDetail.OrderId.ToString();
                txtDiscount.Text = orderDetail.Discount.ToString();
                txtQuantity.Text = orderDetail.Quantity.ToString();
                txtUnitPrice.Text = orderDetail.UnitPrice.ToString();
                txtDiscount.Text = orderDetail.Discount.ToString();

            
                txtMemberId.Text = order.MemberId.ToString();
                txtOrderDate.Text = order.OrderDate.ToString();
                txtRequiredDate.Text = order.RequiredDate.ToString();
                txtShippedDate.Text = order.ShippedDate.ToString();
                txtFreight.Text = order.Freight.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new Order()
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    MemberId = int.Parse(txtMemberId.Text),
                    OrderDate =DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text),

                };
                var b = new OrderDetail()
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    ProductId = int.Parse(txtProductId.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = double.Parse(txtQuantity.Text),
            
                };
                if (UpdateOrInsert == true)
                {
                    OrderDetailRespository.UpdateOrderDetail(b,a);


                }
                else
                {
                    OrderDetailRespository.SaveOrderDetail(b,a);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, UpdateOrInsert == false ? "Add a new Member" : "update a Member");
            }
        }
    }
}
