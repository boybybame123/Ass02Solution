
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
    public partial class frmMemberView : Form
    {
        MemberRepository _memberRepository = new MemberRepository();
        public frmMemberView(Member _member)
        {
            InitializeComponent();
            this.AutoLoadDataInto_Inputs(_member);
        }

        private void btn_Member_Save_Click(object sender, EventArgs e)
        {
            var _tempMemberEmail = _memberRepository.GetMemberByEmail(txt_MemberEmail.Text.ToString());
            var _tempMemberId = _memberRepository.GetMemberById(Int32.Parse(txt_MemberID.Text.ToString()));
            if (txt_MemberEmail.Text.ToString().Equals("")
                || txt_MemberCompanyName.Text.ToString().Equals("")
                || txt_MemberCity.Text.ToString().Equals("")
                || txt_MemberCountry.Text.ToString().Equals("")
                || txt_MemberPassword.Text.ToString().Equals(""))
            {
                MessageBox.Show("Invalid Input.");
            }
            else if (_tempMemberEmail == null || _tempMemberEmail.MemberId == _tempMemberId.MemberId)
            {
                var _tempMember = _memberRepository.GetMemberById(Int32.Parse(txt_MemberID.Text.ToString()));
                _tempMember.Email = txt_MemberEmail.Text;
                _tempMember.CompanyName = txt_MemberCompanyName.Text;
                _tempMember.City = txt_MemberCity.Text;
                _tempMember.Country = txt_MemberCountry.Text;
                _tempMember.Password = txt_MemberPassword.Text;

                _memberRepository.UpdateMember(_tempMember);
                this.Close();
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Member Email Address cannot be dupplicated.");
            }
        }

        private void btn_Member_Cancel_Click(object sender, EventArgs e)
        {
            var _tempMember = _memberRepository.GetMemberById(Int32.Parse(txt_MemberID.Text.ToString()));
            this.AutoLoadDataInto_Inputs(_tempMember);
        }

        public void AutoLoadDataIntoInputs(Member _member)
        {
            txt_MemberID.Text = _member.MemberId.ToString();
            txt_MemberEmail.Text = _member.Email.ToString();
            txt_MemberCompanyName.Text = _member.CompanyName.ToString();
            txt_MemberCity.Text = _member.City.ToString();
            txt_MemberCountry.Text = _member.Country.ToString();
            txt_MemberPassword.Text = _member.Password.ToString();
        }

        private void frmMemberUpdate_Load(object sender, EventArgs e)
        {

        }

        private void frmMemberUpdate_Load_1(object sender, EventArgs e)
        {

        }
        
    }
}
