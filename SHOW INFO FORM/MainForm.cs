using Project_OOP_Final.DTO;
using Project_OOP_Final.SHOW_INFO_FORM;
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
    public partial class MainForm : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public MainForm(Account acc)
        {
            this.loginAccount = acc;
            InitializeComponent();
            changeAccount(loginAccount.Role);
        }
        #region Method
        void changeAccount (string role)
        {
            lbRole.Text = role;
            btnTask.Enabled = role != "Mentor";
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
            pnMain.Controls.Add(childForm);
            pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Event

        private void PersonalInfo_Member_Load(object sender, EventArgs e)
        {
            
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnHome.Height;
            pnCick.Top = btnHome.Top;
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
        private void btnClubMemberInfo_Click_1(object sender, EventArgs e)
        {
            pnCick.Height = btnClubMemberInfo.Height;
            pnCick.Top = btnClubMemberInfo.Top;
            ShowInfo fShow = new ShowInfo();
            openChildForm(fShow);

            fShow.changeAccount(loginAccount.Role);
        }
        private void btnTask_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnTask.Height;
            pnCick.Top = btnTask.Top;
            if (loginAccount.Role == "Member")
            {
                
                openChildForm(new MemberClubTask(loginAccount.Id));
            }
            else
            {

                openChildForm(new ClubTask());
            }
        }
        private void btnClubActivityInfo_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnClubActivityInfo.Height;
            pnCick.Top = btnClubActivityInfo.Top;
            ClubInfo clubInfo = new ClubInfo();
            openChildForm(clubInfo);
            clubInfo.changeAccount(loginAccount.Role);
        }
        private void btnAdjustPersonalInfo_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnAdjustPersonalInfo.Height;
            pnCick.Top = btnAdjustPersonalInfo.Top;
            AdjustPersonalInfo fAdjustPersonalInfo = new AdjustPersonalInfo();
            openChildForm(fAdjustPersonalInfo);
            fAdjustPersonalInfo.getUserNameAndRole(loginAccount.UserName, loginAccount.Role);
        }
        private void btnAdjustPassword_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnAdjustPassword.Height;
            pnCick.Top = btnAdjustPassword.Top;
            AdjustPass fAdjustPass = new AdjustPass();
            openChildForm(fAdjustPass);
            fAdjustPass.getPassNow(loginAccount.Password);
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        
    }
}
