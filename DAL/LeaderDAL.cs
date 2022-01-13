using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    public class LeaderDAL : PersonDAL
    {
        private static LeaderDAL instance;
        public static LeaderDAL Instance
        {
            get { if (instance == null) instance = new LeaderDAL(); return instance; }
            private set { instance = value; }
        }
        public LeaderDAL() { }
        public Leader getInfoById(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Info_Leader Where Id = '" + id + "'");
            foreach (DataRow row in data.Rows)
            {
                return new Leader(row);
            }
            return null;
        }
        public override int addNew(string name, string clas, string phone, string team)
        {
            string sql = "Insert into Info_Leader(Name,Class,Phone,Team) VALUES('" + name + "','" + clas + "','" + phone + "', '" + team + "')";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public override int remove(string id, string role)
        {
            string sql = "DELETE FROM Info_Leader WHERE Id='" + id + "' and role='" + role + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public int addNewTask(string idMember, string taskName, string deadline, string note, string priority)
        {
            string sql = "Insert INTO Info_Task(Id_Member,Task_Name,Deadline, Note, Priority) VALUES('" + idMember + "','" + taskName + "','" + deadline + "', '" + note + "', '" + priority + "')";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public int removeTask(string taskId)
        {
            string sql = "DELETE FROM Info_Task WHERE Task_Id ='" + taskId + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public int redoTask(string taskId, string note)
        {
            string sql = "Update Info_Task SET Status = 'Re-do task', Note = '" + note + "' WHERE Task_Id = '" + taskId + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        
    }
}
