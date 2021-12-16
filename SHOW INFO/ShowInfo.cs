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
            loadInfoListByRole();

        }
        #region Method
        public void changeAccount(string role)
        {
            pnForLeader.Visible = role == "Leader";

        }
        void loadInfoListByRole()
        {
            dtgvShowMember.DataSource = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadInfoListMember");
            dtgvShowLeader.DataSource = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadInfoListLeader");
            dtgvShowMentor.DataSource = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadInfoListMentor");
        }
        #endregion

        #region Event
        private void button2_Click(object sender, EventArgs e)
        {
            Remove fRemove = new Remove();
            
            fRemove.Show();
        }

        private void ShowInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            AddNewMember fAddNew = new AddNewMember();
            this.Hide();
            fAddNew.ShowDialog();
        }

        #endregion

    }
}
