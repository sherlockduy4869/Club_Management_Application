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
    public partial class AddNewActivity : Form
    {
        public AddNewActivity()
        {
            InitializeComponent();
        }
        private void AddNewActivity_Load(object sender, EventArgs e)
        {

        }

        #region Event
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string dateStart = dtpkStart.Text;
            string dateEnd = dtpkEnd.Text;

            try
            {

                    int i = ActivityDAL.Instance.addNew(name, dateStart, dateEnd);

                    if (i != 0)
                    {
                        txbName.Text = string.Empty;
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
        #endregion

    }

}
