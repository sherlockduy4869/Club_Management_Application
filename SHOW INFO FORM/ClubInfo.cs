using Project_OOP_Final.DAL;
using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP_Final
{
    public partial class ClubInfo : Form
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public ClubInfo()
        {
            InitializeComponent();
            loadClubInfo();
            loadACtivity();
        }

        #region Method
        public void changeAccount(string role)
        {
            btnAdd.Visible = role == "Leader";
            btnAdjust.Visible = role == "Leader";
            btnAddItem.Enabled = role == "Leader";
            txbItemName.Enabled = role == "Leader";
            txbPrice.Enabled = role == "Leader";
            nmCount.Enabled = role == "Leader";
        }
        void loadClubInfo()
        {
            dtgvActivity.DataSource = DataProvider.Instance.ExecuteQuery("EXEC dbo.LoadInfoActivity");
        }
        void loadACtivity()
        {
            List<Activity> list = ActivityDAL.Instance.loadActivityList();
            foreach (Activity activity in list)
            {
                Button btn = new Button();
                btn.Click += btn_Click;
                btn.Tag = activity;
                btn.Width = 180;
                btn.Height = 180;
                btn.BackColor = Color.FromArgb(246, 174, 0);
                btn.Text = activity.Name;
                flpActivity.Controls.Add(btn);
            }
        }
        
        void showFinanceDetail(string id)
        {   
            lsvDetailFinance.Items.Clear();
            List<FinanceDetail> list = FinanceDetailDAL.Instance.getFinanceDetail(id);
            int totalPrice = 0;
            foreach (FinanceDetail item in list)
            {
                ListViewItem listViewItem = new ListViewItem(item.ItemName.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.Quantity.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvDetailFinance.Items.Add(listViewItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTotalPrice.Text = totalPrice.ToString("c", culture);
        }
        void btn_Click (object sender, EventArgs e)
        {
            string idActivity = ((sender as Button).Tag as Activity).Id;
            showFinanceDetail(idActivity);
            lsvDetailFinance.Tag = (sender as Button).Tag;
        }
        #endregion

        #region Event

        private void ClubInfo_Load(object sender, EventArgs e)
        {

        }
        private void btnAddIteam_Click(object sender, EventArgs e)
        {
            try
            {
                Activity activity = lsvDetailFinance.Tag as Activity;
                string itemName = txbItemName.Text;
                int price = Convert.ToInt32(txbPrice.Text);
                int quantity = Convert.ToInt32(nmCount.Value);

                FinanceDetailDAL.Instance.insertFinanceDetail(activity.Id, itemName, price, quantity);
                showFinanceDetail(activity.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 404");
            }
        }
        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Only accept numeric values and backspace");
            }
        }
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            dtgvActivity.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Info_Activity WHERE Name like '%" + txbSearch.Text + "%'");
        }

        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewActivity addNewActivity = new AddNewActivity();
            this.Hide();
            addNewActivity.ShowDialog();
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            AdjustActivity adjustActivity = new AdjustActivity();

            adjustActivity.Show();
        }

        #endregion

        
    }
}
