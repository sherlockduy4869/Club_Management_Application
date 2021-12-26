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
            loadRole();
        }
        #region Method
        void loadRole()
        {
            List<string> roles = new List<string>();
            roles.Add("Member");
            roles.Add("Leader");
            roles.Add("Mentor");
            cbRole.DataSource = roles;
        }
        #endregion

        #region Event
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string role = cbRole.Text;

            var roleObject = GettingRole.getRoleForRemoving(role);
            try
            {
                var implementObject = new ImplementFunction();
                int i = implementObject.startRemove(roleObject, id, role);
                if(i != 0)
                {
                    txbID.Text = string.Empty;
                    MessageBox.Show("Removed");
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
