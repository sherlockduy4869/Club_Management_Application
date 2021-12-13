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
    public partial class PersonalInfo : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public PersonalInfo(Account acc)
        {
            this.loginAccount = acc;
            InitializeComponent();
            changeAccount(loginAccount.Role);
        }
        #region Method
        void changeAccount (string role)
        {
            lbRole.Text = role;
            btnClubTask.Enabled = role != "Mentor";
            
        }
        public void showPersonalInfor(string id, string role, string name, string clas, string phone)
        {

            txbID.Text = id;
            txbName.Text = name;
            txbClass.Text = clas;
            txbPhone.Text = phone;
            txbRole.Text = role;

        }
        #endregion

        #region Event

        private void PersonalInfo_Member_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowCLubInfo_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowInfo fShow = new ShowInfo();
            fShow.changeAccount(loginAccount.Role);

            fShow.ShowDialog();
            this.Show();

        }

        private void btnAdjustInfo_Click(object sender, EventArgs e)
        {
            AdjustPersonalInfo fAdjustPersonalInfo = new AdjustPersonalInfo();
            fAdjustPersonalInfo.getUserNameAndRole(loginAccount.UserName, loginAccount.Role);
            this.Hide();
            fAdjustPersonalInfo.ShowDialog();
            this.Show();
        }

        private void btnAdjustPass_Click(object sender, EventArgs e)
        {
            AdjustPass fAdjustPass = new AdjustPass();
            fAdjustPass.getPassNow(loginAccount.Password);
            this.Hide();
            fAdjustPass.ShowDialog();
            this.Show();
        }

        private void btnClubInfo_Click(object sender, EventArgs e)
        {
            ClubInfo clubInfo = new ClubInfo();
            clubInfo.changeAccount(loginAccount.Role);
            this.Hide();
            clubInfo.ShowDialog();
            this.Show();
        }

        private void btnClubTask_Click(object sender, EventArgs e)
        {
            if(loginAccount.Role == "Member")
            {
                MemberTask membertask = new MemberTask(loginAccount.Id);
                
                this.Hide();
                membertask.ShowDialog();
                this.Show();
                
            }
            else
            {
                ClubTask clubtask = new ClubTask();
                this.Hide();
                clubtask.ShowDialog();
                this.Show();
            }
        }
        #endregion

    }
}
