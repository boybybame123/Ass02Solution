using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        BindingSource source;
        public Member emails { get; set; }
        public bool adminOrMember { get; set; }
        IMember mem = new MemberRepository();
        public frmMembers()
        {
            InitializeComponent();
        }
      

       
        public void loadListMember()                     
        {


            var member = mem.GetMember() ;
            try
            {
                source = new BindingSource(); 
                source.DataSource = member; 

                txtMemberId.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");
             

                dgvMember.DataSource = null;
                dgvMember.DataSource = source;
              
                if (member.Count() == 0)
                {
                    clearText();
                    btnDeletes.Enabled = false;
                }
                else
                {
                    btnDeletes.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member" +
                    " List");
            }

        }
        public void loadMember(Member email)// Từ dữ liệu Car đổ cào DATAGRIDVIEW
        {

            var mail = email.Email;
            var member = mem.LoginMember(mail);
            try
            {
                source = new BindingSource(); // là cột column trong Datagridview 
                source.DataSource = member; /// Thêm dữ liệu car vào BindingSource

                txtMemberId.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                /// Tạo tên cho các cột trong DATAGRIDVIEW
                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");
                // lÀM TRỐNG DATAGRIDVIEW và sau đó chèn dữ liệu car vào bảng DgvCarList

                dgvMember.DataSource = null;
                dgvMember.DataSource = source;
                /// Nếu ko có dữ liệu Car thì sẽ ẩn nút DELETE
                
               
                  
               btnDeletes.Enabled = false;
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member" +
                    " List");
            }

        }

        private void clearText()
        {
            txtMemberId.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtCompanyName.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtCountry.Text = String.Empty;
            txtPassword.Text = String.Empty;

        }
        ///member12@fstore.com
        private Member GetsMemberObjects()
        {
            Member member = null;
            try
            {
                member = new Member()
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text,

                };
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member!!!");
                
            }
            return member;

        }

        private void btnReads_Click(object sender, EventArgs e)
        {
            if (adminOrMember == false)
            {
                loadMember(emails);
            }
            else
            {
                loadListMember();
            }
        }
        private void frmMembers_Load(object sender, EventArgs e)
        {
            if (adminOrMember == true)
            {
            }
            else
           {
                btnCreate.Enabled = false;;
            }
        }
        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            frmMembersDetail detail = new frmMembersDetail()
            {
                Text = "Add Member ",
                UpdateOrInsert = false,
                member = GetsMemberObjects(),
                MemberRespository = mem

            };
            if (detail.ShowDialog() == DialogResult.OK)
            {
                loadListMember();
            }
                

        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeletes_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetsMemberObjects();
                mem.DeleteMember(member);
                loadListMember();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a car");
            }
        }

        private void dgvMember_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMember_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            frmMembersDetail detail = new frmMembersDetail()
            {
                Text = "update",
                UpdateOrInsert = true,
                member = GetsMemberObjects(),
                MemberRespository = mem

            };
            if (detail.ShowDialog() == DialogResult.OK)
            {

                if (adminOrMember == true)
                {

                    loadListMember();
                }
                else if (adminOrMember == false)
                {

                    loadMember(emails);
                }
            }
        }
    }
}
