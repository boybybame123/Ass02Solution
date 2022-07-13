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
    public partial class frmMain : Form
    {

        IMember ac = new MemberRepository();
        BindingSource source;
        public Member email { get; set; }
        public bool AdminOrMember { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (AdminOrMember == false)
            {
                btnProductManagement.Enabled = false;
            }
        }
            private void button2_Click(object sender, EventArgs e) { 
        
                frmProducts pr = new frmProducts()
                {
                    Text = "List Product",
                    Emails = email,
                    adminOrMembers = AdminOrMember
                };
                pr.ShowDialog();
                MessageBox.Show("okkk");
            
            
          

        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {
            frmMembers mem = new frmMembers()
            {
                Text = "list member",
                emails = email,
                adminOrMember = AdminOrMember
                
            };
            mem.ShowDialog();
            MessageBox.Show("okkk");
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            frmOrders orders = new frmOrders() { 
                Text = "Order ",
                Email =email,
                adminsOrMember = AdminOrMember
            
            };
            orders.ShowDialog();
            MessageBox.Show("okkk");
        }
    }
}
