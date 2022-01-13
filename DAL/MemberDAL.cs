using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    public class MemberDAL : PersonDAL
    {
        private static MemberDAL instance;
        public static MemberDAL Instance
        {
            get { if (instance == null) instance = new MemberDAL(); return instance; }
            private set { instance = value; }
        }
        public MemberDAL() { }
        public Member getInfoById(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Info_Member Where Id = '" + id + "'");
            foreach (DataRow row in data.Rows)
            {
                return new Member(row);
            }
            return null;
        }
        public override int addNew(string name, string clas, string phone, string team)
        {
            string sql = "Insert into Info_Member(Name,Class,Phone,Team) VALUES('" + name + "','" + clas + "','" + phone + "', '" + team + "')";

            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public override int remove(string id, string role)
        {
            string sql = "DELETE FROM Info_Member WHERE Id='" + id + "' and role='" + role + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public int submitTask(string id, string taskId)
        {
            string sql = "UPDATE Info_Task SET Status = 'Done' WHERE Id_Member = '" + id + "' AND Task_Id = '" + taskId + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;

        }
        public List<string> getMemberId()
        {
            List<string> list = new List<string>();
            string sql = "SELECT Id, Name, Class, Phone, Role, Team FROM Info_Member";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow row in data.Rows)
            {
                Member member = new Member(row);
                list.Add(member.Id);
            }
            return list;
        }
        public List<string> getTaskId()
        {
            List<string> list = new List<string>();
            string sql = "SELECT Id_Member, Task_Id, Task_Name, Deadline, Status, Priority FROM Info_Task";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow row in data.Rows)
            {
                MemberTask task = new MemberTask(row);
                list.Add(task.TaskId);
            }
            return list;
        }
    }
}
