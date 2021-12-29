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
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChildForm.Controls.Add(childForm);
            pnChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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

        private void btnAdjustInfo_Click_1(object sender, EventArgs e)
        {
            openChildForm(new AdjustPersonalInfo());
            AdjustPersonalInfo fAdjustPersonalInfo = new AdjustPersonalInfo();
            fAdjustPersonalInfo.getUserNameAndRole(loginAccount.UserName, loginAccount.Role);
        }
        private void btnAdjustPass_Click_1(object sender, EventArgs e)
        {
            openChildForm(new AdjustPass());
            AdjustPass fAdjustPass = new AdjustPass();
            fAdjustPass.getPassNow(loginAccount.Password);

        }

        private void btnClubInfo_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ClubInfo());

            ClubInfo clubInfo = new ClubInfo();
            clubInfo.changeAccount(loginAccount.Role);
        }
        private void btnClubTask_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ClubTask());
            if (loginAccount.Role == "Member")
            {
                MemberClubTask memberclubtask = new MemberClubTask(loginAccount.Id);
            }
            else
            {
                ClubTask clubtask = new ClubTask();
            }
        }
        private void btnCLubMemberInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new ShowInfo());

            ShowInfo fShow = new ShowInfo();
            fShow.changeAccount(loginAccount.Role);

        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


    }
}
