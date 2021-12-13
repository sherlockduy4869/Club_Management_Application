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
            txbID.Text = string.Empty;
            txbName.Text = string.Empty;
            txbPhone.Text = string.Empty;
            txbClass.Text = string.Empty;
            txbRole.Text = string.Empty;
        }
        #endregion
        #region Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string name = txbName.Text;
            string clas = txbClass.Text;
            string phone = txbPhone.Text;
            string role = txbRole.Text;

            try
            {
               
                if(role == "Member")
                {
                    int i = MemberDAL.Instance.addNew(id, name, clas, phone);

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
                else if (role == "Leader")
                {
                    int i = LeaderDAL.Instance.addNew(id, name, clas, phone);

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
                    int i = MentorDAL.Instance.addNew(id, name, clas, phone);

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
                    MessageBox.Show("Please enter right Role");
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
