using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    public class FinanceDetailDAL
    {
        private static FinanceDetailDAL instance;
        public static FinanceDetailDAL Instance
        {
            get { if (instance == null) instance = new FinanceDetailDAL(); return instance; }
            private set { instance = value; }
        }
        private FinanceDetailDAL() { }
        public List<FinanceDetail> getFinanceDetail (string id)
        {
            List<FinanceDetail> list = new List<FinanceDetail>();
            string sql = "SELECT ItemName, Price, Quantity, Price*Quantity AS TotalPrice FROM Finance_Detail WHERE IdActivity = '" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow row in data.Rows)
            {
                FinanceDetail financeDetail = new FinanceDetail(row);
                list.Add(financeDetail);
            }
            return list;
        }
        public void insertFinanceDetail(string id, string itemName, int price, int quantity)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_InsertFinanceDetail @idActivity , @itemName , @price , @quantity", new object[] {id, itemName, price, quantity});
            
        }
    }
}
