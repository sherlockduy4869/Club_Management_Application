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
    public partial class AdjustActivity : Form
    {
        public AdjustActivity()
        {
            InitializeComponent();
        }
        private void AdjustActivity_Load(object sender, EventArgs e)
        {

        }
        #region Method
        void reFresh()
        {
            txbId.Text = string.Empty;
            txbName.Text = string.Empty;
            txbDateStart.Text = string.Empty;
            txbDateEnd.Text = string.Empty;
        }
        #endregion
        #region Event
        private void btnAdjust_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            string name = txbName.Text;
            string dateStart = txbDateStart.Text;
            string dateEnd = txbDateEnd.Text;
            try
            {

                int i = ActivityDAL.Instance.adjust(id, name, dateStart, dateEnd);

                if (i != 0)
                {
                    reFresh();
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
        #endregion
    }
}
