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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }
        #region Method
        void ReFresh()
        {
            txbID.Text = string.Empty;
            txbRole.Text = string.Empty;
        }
        #endregion

        #region Event
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string role = txbRole.Text;

            try
            {
                if(role == "Member")
                {
                    int i = MemberDAL.Instance.remove(id, role);
                    if (i != 0)
                    {
                        ReFresh();
                        MessageBox.Show("Removed");

                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else if (role == "Leader")
                {
                    int i = LeaderDAL.Instance.remove(id, role);
                    if (i != 0)
                    {
                        ReFresh();
                        MessageBox.Show("Removed");

                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else if (role == "Mentor")
                {
                    int i = MentorDAL.Instance.remove(id, role);
                    if (i != 0)
                    {
                        ReFresh();
                        MessageBox.Show("Removed");

                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter right information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 404");
            }
        }
        private void Remove_Load(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
        #endregion
    }
}
