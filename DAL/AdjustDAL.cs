using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    public class AdjustDAL
    {
        private static AdjustDAL instance;
        public static AdjustDAL Instance
        {
            get { if (instance == null) instance = new AdjustDAL(); return instance; }
            private set { instance = value; }
        }
        private AdjustDAL() { }

        public int adjustPass(string userName, string newPass)
        {
            string sql = "EXEC dbo.Adjust_Pass @userName= '" + userName + "',@newPass= '" + newPass + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public int adjustPersonalInfo(string userName, string name, string clas, string phone, string rol)
        {
            string sql = "EXEC dbo.Adjust_Info @userName= '" + userName + "',@name= '" + name + "',@clas='" + clas + "', @phone='" + phone + "', @role='" + rol + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
    }
}
