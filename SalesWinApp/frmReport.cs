using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmReport : Form
    {
        public Member EmailforReport { get; set; }
        public bool adminsOrMembers { get; set; }
        IOrderDetail report = new OrderDetailRepository();
        public Order orders { get; set; }
        public OrderDetail orderDetails { get; set; }
        BindingSource source;
        public frmReport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSubmit_Click(object sender, EventArgs e)
        {

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            if (adminsOrMembers == true)
            {
                loadListOrđer();
            }
            else if (adminsOrMembers == false)
            {

                loadListOrderbyMember(EmailforReport);
            }
        }
        public void loadListOrđer()                    
        {


            var member = report.SearchOrderByShippedDate();



            try
            {
                source = new BindingSource(); 
                source.DataSource = member;
                Dgv.DataSource = null;

                Dgv.DataSource = source;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail Report !!!");
            }

        }
        public void loadListOrderbyMember(Member a)
        {

            var p = a.MemberId;
            var member = report.SearchOrderByShippedDatebyMember(p);

            try
            {
                source = new BindingSource();
                source.DataSource = member;
                Dgv.DataSource = null;

                Dgv.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }

        }

        private void txtRead_Click(object sender, EventArgs e)
        {

        }

        private void txtCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
