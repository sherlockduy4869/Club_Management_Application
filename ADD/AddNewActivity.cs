using Project_OOP_Final.DAL;
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
    public partial class AddNewActivity : Form
    {
        public AddNewActivity()
        {
            InitializeComponent();
        }
        private void AddNewActivity_Load(object sender, EventArgs e)
        {

        }

        #region Method
        void ReFresh()
        {
            txbName.Text = string.Empty;
            txbDateStart.Text = string.Empty;
            txbDateEnd.Text = string.Empty;
        }
        #endregion

        #region Event
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            ClubInfo clubInfo = new ClubInfo();
            clubInfo.ShowDialog();
        }
    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string dateStart = txbDateStart.Text;
            string dateEnd = txbDateEnd.Text;
            try
            {

                    int i = ActivityDAL.Instance.addNew(name, dateStart, dateEnd);

                    if (i != 0)
                    {
                        ReFresh();
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
        #endregion
    }

}
