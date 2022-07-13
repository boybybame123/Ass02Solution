using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {

        IMember ic = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fileName = "appsettings.json";
            string json = File.ReadAllText(fileName);
            var adminAccount = JsonSerializer.Deserialize<DefaultAccount>(json, null);
            string email = adminAccount.Email;
            string password = adminAccount.Password;
            string mail = txtEmail.Text;
            if (txtEmail.Text == null || txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Please Input Email");
            }else if (txtPassWord.Text == null || txtPassWord.Equals(""))
            {
                MessageBox.Show("Please Input Password");
            }
           

            if (txtEmail.Text == email && txtPassWord.Text == password)
            {
                MessageBox.Show(email + " - " + password);
                frmMain main = new frmMain()
                {
                    Text = "Main For Admin",
                     AdminOrMember = true
                };
            this.Hide();
            main.ShowDialog();
        }
            else if (ic.LoginMember(txtEmail.Text) != null)
            {
                MessageBox.Show(txtEmail.Text + " - " + txtPassWord.Text);
                frmMain main = new frmMain()
                {
                    Text = $"Main For {txtEmail.Text}",
                    AdminOrMember = false,
                    email = ic.LoginMember(txtEmail.Text)
                   
                };
                this.Hide();
                main.ShowDialog();


            }
  }


    }
            

}
