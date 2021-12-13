using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    public class MemberTaskDAL
    {
        private static MemberTaskDAL instance;
        public static MemberTaskDAL Instance
        {
            get { if (instance == null) instance = new MemberTaskDAL(); return instance; }
            private set { instance = value; }
        }
        private MemberTaskDAL() { }
        public int submitTask(string id, string taskId)
        {
            string sql = "UPDATE Info_Task SET Status = 'Done' WHERE Id_Member = '" + id + "' AND Task_Id = '" + taskId + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;

        }
    }
    
}
