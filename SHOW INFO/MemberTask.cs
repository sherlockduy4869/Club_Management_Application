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
        #endregion
    }
}
