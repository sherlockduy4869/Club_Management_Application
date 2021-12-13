using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DTO
{
    public class Account
    {
        private string _id;
        private string _userName;
        private string _passWord;
        private string _role;

        public Account(DataRow row)
        {
            _id = (string)row["Id"];
            _userName = (string)row["UserName"];
            _passWord = (string)row["Pass"];
            _role = (string)row["Role"];
        }
        public Account(string id, string userName, string passWord, string role)
        {
            _id = id;
            _userName = userName;
            _passWord = passWord;
            _role = role;
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _passWord; }
            set { _passWord = value; }
        }
        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }
    }
}
