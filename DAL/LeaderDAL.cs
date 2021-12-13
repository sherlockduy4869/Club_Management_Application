using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    public class LeaderDAL
    {
        private static LeaderDAL instance;
        public static LeaderDAL Instance
        {
            get { if (instance == null) instance = new LeaderDAL(); return instance; }
            private set { instance = value; }
        }
        private LeaderDAL() { }
        public Leader getInfoById(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Info_Leader Where Id = '" + id + "'");
            foreach (DataRow row in data.Rows)
            {
                return new Leader(row);
            }
            return null;
        }
        public int addNew(string id, string name, string clas, string phone)
        {
            string sql = "Insert into Info_Leader(Id,Name,Class,Phone) VALUES('" + id + "','" + name + "','" + clas + "','" + phone + "')";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public int remove(string id, string role)
        {
            string sql = "DELETE FROM Info_Leader WHERE Id='" + id + "' and role='" + role + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
    }
}
