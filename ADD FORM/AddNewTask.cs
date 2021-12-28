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
            loadPriority();
        }
        private void AddTask_Load(object sender, EventArgs e)
        {

        }
        #region Method
        void reFresh()
        {
            txbIdMember.Text = string.Empty;
            txbTaskName.Text = string.Empty;
            txbNote.Text = string.Empty;
        }
        void loadPriority()
        {
            List<string> priorityList = new List<string>();
            priorityList.Add("Normal");
            priorityList.Add("Important");
            priorityList.Add("Very Important");
            cbPriority.DataSource = priorityList;
        }
        #endregion
        #region Event
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string idMember = txbIdMember.Text;
            string taskName = txbTaskName.Text;
            string deadline = dtpkDeadline.Text;
            string note = txbNote.Text;
            string priority = cbPriority.Text;

            try
            {
                int i = LeaderDAL.Instance.addNewTask(idMember, taskName, deadline, note, priority);

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
