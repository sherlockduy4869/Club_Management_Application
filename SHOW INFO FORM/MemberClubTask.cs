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
    public partial class MemberClubTask : Form
    {
        private string _id;

        public string Id { get; internal set; }

        public MemberClubTask(string id)
        {
            InitializeComponent();
            _id = id;
            loadMemberTask(id);
        }
        public MemberClubTask(DataRow row)
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

                if (priority == "Important")
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(246, 174, 0);
                }
                else if (priority == "Very Important")
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(178, 8, 55);
                }
            }
        }
        #endregion


    }
}
