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

namespace Project_OOP_Final.REMOVE
{
    public partial class RemoveTask : Form
    {
        public RemoveTask()
        {
            InitializeComponent();
        }
        #region Event
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string taskId = txbTaskId.Text;

            try
            {
                int i = LeaderTaskDAL.Instance.removeTask(taskId);

                if (i != 0)
                {
                    txbTaskId.Text = string.Empty;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void RemoveTask_Load(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
