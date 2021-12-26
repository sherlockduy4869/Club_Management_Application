using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    public class MemberDAL : IPersonDAL
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
        public int addNew(string name, string clas, string phone, string team)
        {
            string sql = "Insert into Info_Member(Name,Class,Phone,Team) VALUES('" + name + "','" + clas + "','" + phone + "', '" + team + "')";

            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public int remove(string id, string role)
        {
            string sql = "DELETE FROM Info_Member WHERE Id='" + id + "' and role='" + role + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
    }
}
