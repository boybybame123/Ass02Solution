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
    public partial class frmMembersDetail : Form
    {
        public IMember MemberRespository { get; set; }

        public bool UpdateOrInsert { get; set; }
        public Member member { get; set; }

        public frmMembersDetail()
        {
            InitializeComponent();
        }

        private void frmMembersDetail_Load(object sender, EventArgs e)
        {
            txtMemberId.Enabled = false;
            txtMemberId.Enabled = !UpdateOrInsert;
            if(UpdateOrInsert  == true)
            {
                txtMemberId.Text = member.MemberId.ToString();
                txtEmail.Text = member.Email.ToString();
                txtCompanyName.Text = member.CompanyName.ToString();
                txtCity.Text = member.City.ToString();
                txtCountry.Text = member.Country.ToString();
                txtPassword.Text = member.Password.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string MemberEmail = txtEmail.Text;
           if(MemberRespository.GetListMemberbyEmail(MemberEmail) != null)
            {
                MessageBox.Show("Gmail was Exist ! Please chooose another one !!");
                return;
            }
            if (txtPassword.Text ==null ||txtPassword.Text.Equals(""))
                
            {
                MessageBox.Show("Please Input password");
                return;
            }
            try
            {
                
                var member = new Member()
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
                if (UpdateOrInsert == false)
                {
                   
                    MemberRespository.SaveMember(member);

                }
                else
                {
                    MemberRespository.UpdateMember(member);
                   
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, UpdateOrInsert == false ? "Add a new Member" : "update a Member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
