using Project_OOP_Final.DAL;
using Project_OOP_Final.DTO;
using Project_OOP_Final.SHOW_INFO_FORM;

namespace Project_OOP_Final
{
    public partial class fLogin : Form
    {
        
        public fLogin()
        {
            InitializeComponent();
        }
        #region Method
        bool Login(string userName, string passWord)
        {
            return AccountDAL.Instance.Login(userName, passWord);
        }
        #endregion

        #region Event
        
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;

            if (Login(userName, passWord) == true)
            {
                Account loginAccount = AccountDAL.Instance.getAccountByUserName(userName);
                if (loginAccount.Role == "Member")
                {
                    Member member = MemberDAL.Instance.getInfoById(loginAccount.Id);
                    MainForm mainForm = new MainForm(loginAccount);
                    mainForm.showPersonalInfor(member.Id, member.Role, member.Name, member.Class, member.Phone);
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else if (loginAccount.Role == "Mentor")
                {
                    Mentor mentor = MentorDAL.Instance.getInfoById(loginAccount.Id);
                    MainForm mainForm = new MainForm(loginAccount);
                    mainForm.showPersonalInfor(mentor.Id, mentor.Role, mentor.Name, mentor.Class, mentor.Phone);
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else
                {
                    Leader leader = LeaderDAL.Instance.getInfoById(loginAccount.Id);
                    MainForm mainForm = new MainForm(loginAccount);
                    mainForm.showPersonalInfor(leader.Id, leader.Role, leader.Name, leader.Class, leader.Phone);
                    this.Hide();
                    mainForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong UserName or PassWord, please re-enter again");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbUserName_Click(object sender, EventArgs e)
        {
            txbUserName.Clear();

        }

        private void txbPassWord_Click(object sender, EventArgs e)
        {
            txbPassWord.Clear();

        }

        #endregion
    }
}