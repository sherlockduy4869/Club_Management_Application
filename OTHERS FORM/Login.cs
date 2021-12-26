using Project_OOP_Final.DAL;
using Project_OOP_Final.DTO;

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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            
            if (Login(userName,passWord)== true)
            {
                Account loginAccount = AccountDAL.Instance.getAccountByUserName(userName);
                if (loginAccount.Role == "Member")
                {
                    Member member = MemberDAL.Instance.getInfoById(loginAccount.Id);
                    PersonalInfo personalInfo = new PersonalInfo(loginAccount);
                    personalInfo.showPersonalInfor(member.Id, member.Role, member.Name, member.Class, member.Phone);
                    this.Hide();
                    personalInfo.ShowDialog();
                }
                else if (loginAccount.Role == "Mentor")
                {
                    Mentor mentor = MentorDAL.Instance.getInfoById(loginAccount.Id);
                    PersonalInfo personalInfo = new PersonalInfo(loginAccount);
                    personalInfo.showPersonalInfor(mentor.Id, mentor.Role, mentor.Name, mentor.Class, mentor.Phone);
                    this.Hide();
                    personalInfo.ShowDialog();
                }
                else if (loginAccount.Role == "Leader")
                {
                    Leader leader = LeaderDAL.Instance.getInfoById(loginAccount.Id);
                    PersonalInfo personalInfo = new PersonalInfo(loginAccount);
                    personalInfo.showPersonalInfor(leader.Id, leader.Role, leader.Name, leader.Class, leader.Phone);
                    this.Hide();
                    personalInfo.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Sai cmnr");
                }
            }
            else
            {
                MessageBox.Show("Wrong!!!");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        #endregion


    }
}