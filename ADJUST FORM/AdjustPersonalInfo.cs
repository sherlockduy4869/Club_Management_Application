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
    public partial class AdjustPersonalInfo : Form
    {
        private string rol;
        public AdjustPersonalInfo()
        {
            InitializeComponent();
            
        }
        
        private void AdjustPersonalInfo_Load(object sender, EventArgs e)
        {
            
        }
        #region Method
        public void getUserNameAndRole(string username, string role)
        {
            txbUserName.Text = username;
            rol = role;
        }
        #endregion
        #region Event
        private void btnAdjust_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string name = txbName.Text;
            string clas = txbClass.Text;
            string phone = txbPhone.Text;

            try
            {

                    int i = AdjustDAL.Instance.adjustPersonalInfo(userName, name, clas, phone, rol);

                    if (i != 0)
                    {
                        txbName.Text = string.Empty;
                        txbPhone.Text = string.Empty;
                        txbClass.Text = string.Empty;

                        MessageBox.Show("Adjusted");

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
            
            this.Close();
            
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
