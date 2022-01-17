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
        void changeAccount (string role) //Roles decentralization
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
        }

        private Form activeForm = null; //UI design
        private void openChildForm(Form childForm) //UI design
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
            pnCick.Height = btnClubMemberInfo.Height; //UI design
            pnCick.Top = btnClubMemberInfo.Top; //UI design

            ShowInfo fShow = new ShowInfo();
            openChildForm(fShow); //UI design
            
            fShow.changeAccount(loginAccount.Role);
        }
        private void btnTask_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnTask.Height; //UI design
            pnCick.Top = btnTask.Top; //UI design

            if (loginAccount.Role == "Member")
            {
                
                openChildForm(new MemberClubTask(loginAccount.Id)); //UI design
            }
            else
            {

                openChildForm(new ClubTask()); //UI design
            }
        }
        private void btnClubActivityInfo_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnClubActivityInfo.Height; //UI design
            pnCick.Top = btnClubActivityInfo.Top; //UI design

            ClubInfo clubInfo = new ClubInfo();
            openChildForm(clubInfo); //UI design

            clubInfo.changeAccount(loginAccount.Role);
        }
        private void btnAdjustPersonalInfo_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnAdjustPersonalInfo.Height; //UI design
            pnCick.Top = btnAdjustPersonalInfo.Top; //UI design

            AdjustPersonalInfo fAdjustPersonalInfo = new AdjustPersonalInfo();
            openChildForm(fAdjustPersonalInfo); //UI design

            fAdjustPersonalInfo.getUserNameAndRole(loginAccount.UserName, loginAccount.Role);
        }
        private void btnAdjustPassword_Click(object sender, EventArgs e)
        {
            pnCick.Height = btnAdjustPassword.Height; //UI design
            pnCick.Top = btnAdjustPassword.Top; //UI design

            AdjustPass fAdjustPass = new AdjustPass();
            openChildForm(fAdjustPass); //UI design

            fAdjustPass.getPassNow(loginAccount.Password);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

    }
}
