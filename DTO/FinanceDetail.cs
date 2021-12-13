using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DTO
{
    public class FinanceDetail
    {
        private string _itemName;
        private int _price;
        private int _quantity;
        private int _totalPrice;
        public FinanceDetail(DataRow row)
        {
            _itemName = (string)row["ItemName"];
            _price = (int)row["Price"];
            _quantity = (int)row["Quantity"];
            _totalPrice = (int)row["TotalPrice"];
        }
        public FinanceDetail(string itemName, int price, int quantity, int totalPrice)
        {
            _itemName = itemName;
            _price = price;
            _quantity = quantity;
            _totalPrice = totalPrice;
        }
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public int TotalPrice
        {
            set { _totalPrice = value; }
            get { return _totalPrice; }
        }
    }
}
