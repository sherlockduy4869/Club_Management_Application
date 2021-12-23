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

namespace Project_OOP_Final.SHOW_INFO_FORM
{
    public partial class MemberHistoryTask : Form
    {
        public MemberHistoryTask(string id)
        {
            InitializeComponent();
            loadMemberDoneTask(id);
        }
        void loadMemberDoneTask(string id)
        {
            dtgvDoneTask.DataSource = DataProvider.Instance.ExecuteQuery("SELECT Task_Id, Task_Name, Deadline, Status FROM Info_Task WHERE Id_Member = '" + id + "' AND Status = 'Done' ");
        }
        private void MemberHistoryTask_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
