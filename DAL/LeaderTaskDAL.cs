using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    public class LeaderTaskDAL
    {
        private static LeaderTaskDAL instance;
        public static LeaderTaskDAL Instance
        {
            get { if (instance == null) instance = new LeaderTaskDAL(); return instance; }
            private set { instance = value; }
        }
        private LeaderTaskDAL() { }

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
