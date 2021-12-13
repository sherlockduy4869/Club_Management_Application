using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    public class ActivityDAL
    {
        private static ActivityDAL instance;
        public static ActivityDAL Instance
        {
            get { if (instance == null) instance = new ActivityDAL(); return instance; }
            private set { instance = value; }
        }
        private ActivityDAL() { }
        public int addNew(string id, string name, string dateStart, string dateEnd)
        {
            string sql = "Insert into Info_Activity (Id,Name,DateStart,DateEnd) VALUES('" + id + "','" + name + "','" + dateStart + "','" + dateEnd + "')";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public int remove(string id)
        {
            string sql = "EXEC dbo.DeLete_Activity @id ='" + id + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public int adjust(string id, string name, string dateStart, string dateEnd)
        {
            string sql = "UPDATE Info_Activity SET Name = '" + name + "', DateStart='" + dateStart + "', DateEnd='" + dateEnd + "' WHERE Id='" + id + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public List<Activity> loadActivityList()
        {
            List<Activity> list = new List<Activity>();
            string sql = "Select * FROM Info_Activity";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow row in data.Rows)
            {
                Activity acti = new Activity(row);
                list.Add(acti);
            }
            return list;
        }
    }

}
