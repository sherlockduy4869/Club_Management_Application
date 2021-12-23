﻿using Project_OOP_Final.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP_Final
{
    public partial class AddNewMember : Form
    {
        public AddNewMember()
        {
            InitializeComponent();
            loadRole();
            loadTeam();
        }
        private void AddNew_Load(object sender, EventArgs e)
        {

        }
        #region Method
        void reFresh()
        {
            txbName.Text = string.Empty;
            txbPhone.Text = string.Empty;
            txbClass.Text = string.Empty;
        }
        void loadRole()
        {
            List<string> roles = new List<string>();
            roles.Add("Member");
            roles.Add("Leader");
            roles.Add("Mentor");
            cbRole.DataSource = roles;
        }
        void loadTeam()
        {
            List<string> team = new List<string>();
            team.Add("None");
            team.Add("Media");
            team.Add("Tech");
            team.Add("HR");
            cbTeam.DataSource = team;
        }
        #endregion
        #region Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string clas = txbClass.Text;
            string phone = txbPhone.Text;
            string role = cbRole.Text;
            string team = cbTeam.Text;

            try
            {
               
                if(role == "Member")
                {
                    int i = MemberDAL.Instance.addNew(name, clas, phone, team);

                    if (i != 0)
                    {
                        reFresh();
                        MessageBox.Show("Added");
                    }
                    
                }
                else if (role == "Leader")
                {
                    int i = LeaderDAL.Instance.addNew(name, clas, phone, team);

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
                else if (role == "Mentor")
                {
                    int i = MentorDAL.Instance.addNew(name, clas, phone);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 404");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ShowInfo fShow = new ShowInfo();
            this.Hide();
            fShow.ShowDialog();
        }
        #endregion
    }
}
