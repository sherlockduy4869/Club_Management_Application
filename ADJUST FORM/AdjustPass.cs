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
    
    public partial class AdjustPass : Form
    {
        private string passNow;
        public AdjustPass()
        {
            InitializeComponent();
        }
        #region Method
        public void getPassNow(string pass)
        {
            passNow = pass;
        }
        #endregion
        #region Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdjustPass_Load(object sender, EventArgs e)
        {

        } 
        private void btnAdjust_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string currentPass = txbCurrentPass.Text;
            string newPass = txbNewPass.Text;
            string reNewPass = txbReEnterPass.Text;
            string pass = passNow;

            try
            {
                
                if(currentPass == pass)
                {   
                    if(newPass == reNewPass)
                    {
                        int i = AdjustDAL.Instance.adjustPass(userName, newPass);

                        if (i != 0)
                        {
                            txbCurrentPass.Text = string.Empty;
                            txbNewPass.Text = string.Empty;
                            txbReEnterPass.Text = string.Empty;

                            MessageBox.Show("Adjusted Pass");

                        }
                        else
                        {
                            MessageBox.Show("Failed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please re enter new password");
                    }
                }
                else
                {
                    MessageBox.Show("Please re enter current password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 404");
            }
        }
        #endregion
    }
}
