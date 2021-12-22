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
    public partial class SubmitTask : Form
    {
        private string _idMember;
        public string IdMember
        {
            get { return _idMember; }
            set { _idMember = value; }
        }
        public SubmitTask(string id)
        {
            InitializeComponent();
            IdMember = id;
            loadMemberId(IdMember);
        }
        public SubmitTask()
        {
            InitializeComponent();
        }

        #region Method
        void loadMemberId(string id)
        {
            txbMemberId.Text = id;
        }
        #endregion

        #region Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void SubmitTask_Load(object sender, EventArgs e)
        {

        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string taskId = txbTaskId.Text;

            try
            {

                int i = MemberTaskDAL.Instance.submitTask(IdMember, taskId);

                if (i != 0)
                {
                    txbTaskId.Text = string.Empty;

                    MessageBox.Show("Submited");

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
