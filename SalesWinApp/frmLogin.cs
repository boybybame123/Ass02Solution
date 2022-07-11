using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class lb_Password : Form
    {
        MemberRepository _memberDAO = new MemberRepository();
        public lb_Password() {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e) {
            
            
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
