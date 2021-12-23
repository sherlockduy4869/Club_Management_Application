using Project_OOP_Final.DAL;
using Project_OOP_Final.SHOW_INFO_FORM;
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
    public partial class MemberTask : Form
    {
        private string _id;
        public MemberTask(string id)
        {
            InitializeComponent();
            _id = id;
            loadMemberTask(id);
        }
        public MemberTask()
        {
            InitializeComponent();

        }
        #region Method
        void loadMemberTask(string id)
        {

            dtgvMemberTask.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Info_Task WHERE Id_Member = '" + id + "' AND (Status = 'Working' OR Status = 'Re-do task')");
        }
        #endregion

        #region Event
        private void MemberTask_Load(object sender, EventArgs e)
        {

        }
        private void btnSubmitTask_Click(object sender, EventArgs e)
        {
            
            SubmitTask submitTask = new SubmitTask(_id);
            submitTask.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHistoryTask_Click(object sender, EventArgs e)
        {
            MemberHistoryTask memberHistoryTask = new MemberHistoryTask(_id);
            this.Hide();
            memberHistoryTask.ShowDialog();
            this.Show();
        }
        private void dtgvMemberTask_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dtgvMemberTask.Rows)
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
