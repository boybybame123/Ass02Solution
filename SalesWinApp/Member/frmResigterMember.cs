using BusinessObject;
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

namespace SaleWinApp
{
    public partial class frmResigterMember : Form
    {
        
        MemberRepository _memberRepository = new MemberRepository();
        public frmResigterMember() {
            InitializeComponent();
        }

        private void btn_Member_Save_Click(object sender, EventArgs e) {
            var _tempMemberEmail = _memberRepository.GetMemberByEmail(txt_MemberEmail.Text.ToString());
            var _tempMemberId = _memberRepository.GetMemberById(Int32.Parse(txt_MemberID.Text.ToString()));
            if (txt_MemberEmail.Text.ToString().Equals("")
                || txt_MemberCompanyName.Text.ToString().Equals("")
                || txt_MemberCity.Text.ToString().Equals("")
                || txt_MemberCountry.Text.ToString().Equals("")
                || txt_MemberPassword.Text.ToString().Equals("")
                || txt_MemberID.Text.ToString().Equals("")) {
                MessageBox.Show("Invalid Input.");
            } else if (_tempMemberId != null) {
                MessageBox.Show("Member Id cannot be dupplicated.");
            } else if (_tempMemberEmail != null) {
                MessageBox.Show("Member Email Address cannot be dupplicated.");
            } else {
                var _tempMember = new Member();
                _tempMember.MemberId = Int32.Parse(txt_MemberID.Text.ToString());
                _tempMember.Email = txt_MemberEmail.Text;
                _tempMember.CompanyName = txt_MemberCompanyName.Text;
                _tempMember.City = txt_MemberCity.Text;
                _tempMember.Country = txt_MemberCountry.Text;
                _tempMember.Password = txt_MemberPassword.Text;

                _memberRepository.AddMember(_tempMember);
                this.Close();
                MessageBox.Show("Added successfully");
            }
        }

        private void btn_Member_Cancel_Click(object sender, EventArgs e) {
            this.ClearInputs();
        }

        public void ClearInputs() {
            txt_MemberEmail.Clear();
            txt_MemberCompanyName.Clear();
            txt_MemberCity.Clear();
            txt_MemberCountry.Clear();
            txt_MemberPassword.Clear();

        }

        private void frmResigterMember_Load(object sender, EventArgs e)
        {

        }
       
    }
}
