using Project_OOP_Final.DAL;
using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP_Final
{
    public partial class ShowInfo : Form
    {

        public ShowInfo()
        {

            InitializeComponent();
            loadInfoMember();

        }
        #region Method
        public void changeAccount(string role)
        {
            btnAddnew.Visible = role == "Leader";
            btnRemove.Visible = role == "Leader";

        }
        void loadInfoMember()
        {
            dtgvShowMember.DataSource = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadInfoListMember");
        }
        void loadInfoLeader()
        {
            dtgvShowMember.DataSource = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadInfoListLeader");
        }
        void loadInfoMentor()
        {
            dtgvShowMember.DataSource = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadInfoListMentor");
        }
        #endregion

        #region Event
        private void ShowInfo_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove fRemove = new Remove();

            fRemove.Show();
        }

        private void btnAddnew_Click_1(object sender, EventArgs e)
        {
            AddNewMember fAddNew = new AddNewMember();
            fAddNew.Show();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            if (lbRole.Text == "Member Information")
            {
                dtgvShowMember.DataSource = DataProvider.Instance.ExecuteQuery("SELECT Id, Name, Class, Phone, Team FROM Info_Member WHERE Name like '%" + txbSearch.Text + "%'");
            }
            else if (lbRole.Text == "Leader Information")
            {
                dtgvShowMember.DataSource = DataProvider.Instance.ExecuteQuery("SELECT Id, Name, Class, Phone, Team FROM Info_Leader WHERE Name like '%" + txbSearch.Text + "%'");
            }
            else if (lbRole.Text == "Mentor Information")
            {
                dtgvShowMember.DataSource = DataProvider.Instance.ExecuteQuery("SELECT Id, Name, Class, Phone, FROM Info_Mentor WHERE Name like '%" + txbSearch.Text + "%'");
            }
        }
        private void btnMentor_Click(object sender, EventArgs e)
        {
            loadInfoMentor();
            lbRole.Text = "Mentor Information";
        }

        private void btnLeader_Click(object sender, EventArgs e)
        {
            loadInfoLeader();
            lbRole.Text = "Leader Information";
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            loadInfoMember();
            lbRole.Text = "Member Information";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
        }
    }
}
