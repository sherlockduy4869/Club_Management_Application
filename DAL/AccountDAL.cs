using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { instance = value; }
        }
        private AccountDAL() { }

        public bool Login(string userName, string passWord)
        {
            string query = "EXEC dbo.Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;  
        }
        public Account getAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Account Where UserName = '"+userName+"'");
            foreach(DataRow row in data.Rows)
            {
                return new Account(row);
            }
            return null;
        }
    }
}
