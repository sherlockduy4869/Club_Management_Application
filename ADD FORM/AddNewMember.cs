using Project_OOP_Final.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP_Final
{
    public partial class AddNewMember : Form
    {
        public AddNewMember()
        {
            InitializeComponent();
            loadRole();
            loadTeam();
        }
        private void AddNew_Load(object sender, EventArgs e)
        {

        }
        #region Method
        void reFresh()
        {
            txbName.Text = string.Empty;
            txbPhone.Text = string.Empty;
            txbClass.Text = string.Empty;
        }
        void loadRole()
        {
            List<string> roles = new List<string>();
            roles.Add("Member");
            roles.Add("Leader");
            roles.Add("Mentor");
            cbRole.DataSource = roles;
        }
        void loadTeam()
        {
            List<string> team = new List<string>();
            team.Add("Media");
            team.Add("Tech");
            team.Add("HR");
            cbTeam.DataSource = team;
        }
        #endregion
        #region Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string clas = txbClass.Text;
            string phone = txbPhone.Text;
            string role = cbRole.Text;
            string team = cbTeam.Text;

            var roleObject = GettingRoleDAL.getRoleForAdding(role);
            try
            {
                int i = ImplementFunction.startAdding(roleObject, name, clas, phone, team);
                if (i != 0)
                {
                    reFresh();
                    MessageBox.Show("Added");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 404");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ShowInfo fShow = new ShowInfo();
            this.Hide();
            fShow.ShowDialog();
        }
        private void txbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Only accept numeric values and backspace");
            }
        }
        #endregion


    }
}
