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
    public partial class AddNewTask : Form
    {
        public AddNewTask()
        {
            InitializeComponent();
        }
        private void AddTask_Load(object sender, EventArgs e)
        {

        }
        #region Method
        void reFresh()
        {
            txbIdMember.Text = string.Empty;
            txbTaskId.Text = string.Empty;
            txbTaskName.Text = string.Empty;
            txbDeadline.Text = string.Empty;
            txbNote.Text = string.Empty;
        }
        #endregion
        #region Event
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string idMember = txbIdMember.Text;
            string taskId = txbTaskId.Text;
            string taskName = txbTaskName.Text;
            string deadline = txbDeadline.Text;
            string note = txbNote.Text;

            try
            {
                int i = LeaderTaskDAL.Instance.addNewTask(idMember, taskId, taskName, deadline, note);

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
            this.Close();
            
        }
        #endregion
    }
}
