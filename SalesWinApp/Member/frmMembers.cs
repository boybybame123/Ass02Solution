using BusinessObject.Models;
using DataAccess.DAO;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmMembers : Form
    {
        
        public frmMembers() {
            InitializeComponent();
        }
        //load member into dgv
        private void LoadMembers() {

            var members = MemberDAO.Instance.GetMemberList();
            txt_MemberID.DataBindings.Clear();
            txt_Email.DataBindings.Clear();
            txt_CompanyName.DataBindings.Clear();
            txt_City.DataBindings.Clear();
            txt_Country.DataBindings.Clear();
            txt_Password.DataBindings.Clear();

            txt_MemberID.DataBindings.Add("Text", members, "MemberID");
            txt_Email.DataBindings.Add("Text", members, "Email");
            txt_CompanyName.DataBindings.Add("Text", members, "CompanyName");
            txt_City.DataBindings.Add("Text", members, "City");
            txt_Country.DataBindings.Add("Text", members, "Country");
            txt_Password.DataBindings.Add("Text", members, "Password");


            dgv_OrderHistory.DataSource = members;
        }
      
        private void frmMembers_Load(object sender, EventArgs e) => LoadMembers();
        

        

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member { MemberId = Int32.Parse(txt_MemberID.Text), Email = txt_Email.Text,  CompanyName = txt_CompanyName.Text
                                        , City = txt_City.Text, Country = txt_Country.Text, Password = txt_Password.Text};
                MemberDAO.Instance.AddMember(member);
                LoadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Member");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    MemberId = int.Parse(txt_MemberID.Text),
                    Email = txt_Email.Text,
                    CompanyName = txt_CompanyName.Text,
                    City = txt_City.Text,
                    Country = txt_Country.Text,
                    Password = txt_Password.Text
                };
                MemberDAO.Instance.UpdateMember(member);
                LoadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Member");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member { MemberId = int.Parse(txt_MemberID.Text) };
                MemberDAO.Instance.RemoveMember(member);
                LoadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Member");
            }
        }

        private void btn_View_Click(object sender, EventArgs e)
        {

        }
    }
}
