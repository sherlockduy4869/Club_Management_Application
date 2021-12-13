using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DTO
{
    public class Member : Person
    {
        public Member(DataRow row)
        {
            _id = (string)row["Id"];
            _name = (string)row["Name"];
            _phone = (string)row["Phone"];
            _role = (string)row["Role"];
            _class = (string)row["Class"];

        }
        public Member(string id, string name, string phone, string role, string clas)
        {
            _id = id;
            _name = name;
            _phone = phone;
            _role = role;
            _class = clas;
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }
        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }
    }
}
