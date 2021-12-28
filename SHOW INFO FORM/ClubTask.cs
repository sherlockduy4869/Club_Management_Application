using Project_OOP_Final.DAL;
using Project_OOP_Final.OTHERS;
using Project_OOP_Final.REMOVE;
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
    public partial class ClubTask : Form
    {
        public ClubTask()
        {
            InitializeComponent();
            loadClubTask();
        }
        #region Method
        void loadClubTask()
        {
            dtgvClubTask.DataSource = DataProvider.Instance.ExecuteQuery("SELECT Id_Member, Name, Task_Id, Task_Name, Deadline, Status, Note, Priority FROM Info_Task");
            
        }
        #endregion

        #region Event
        private void ClubTask_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewTask addTask = new AddNewTask();
            
            addTask.Show();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveTask removeTask = new RemoveTask();
            removeTask.Show();
            
        }
        private void btnRedo_Click(object sender, EventArgs e)
        {
            ReDoTask redotask = new ReDoTask();
            redotask.Show();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            dtgvClubTask.DataSource = DataProvider.Instance.ExecuteQuery("SELECT Id_Member, Name, Task_Id, Task_Name, Deadline, Status, Note, Priority FROM Info_Task WHERE Task_Name like '" + txbSearch.Text + "%'");
        }
        private void dtgvClubTask_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow row in dtgvClubTask.Rows)
            {
                string priority = Convert.ToString(row.Cells["Priority"].Value);

                if (priority == "Normal")
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else if (priority == "Important")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (priority == "Very Important")
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }
        #endregion


    }
}
