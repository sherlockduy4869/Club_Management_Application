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
            txbRole.Text = string.Empty;
            txbTeam.Text = string.Empty;
        }

        #endregion
        #region Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string clas = txbClass.Text;
            string phone = txbPhone.Text;
            string role = txbRole.Text;
            string team = txbTeam.Text;

            try
            {
               
                if(role == "Member")
                {
                    int i = MemberDAL.Instance.addNew(name, clas, phone, team);

                    if (i != 0)
                    {
                        reFresh();
                        MessageBox.Show("Added");
                    }
                    
                }
                else if (role == "Leader")
                {
                    int i = LeaderDAL.Instance.addNew(name, clas, phone, team);

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
                else if (role == "Mentor")
                {
                    int i = MentorDAL.Instance.addNew(name, clas, phone);

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
                else
                {
                    MessageBox.Show("Please enter Role = Member/Leader/Mentor");
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
        #endregion
    }
}
