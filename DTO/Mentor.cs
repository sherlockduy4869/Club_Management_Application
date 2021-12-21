using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DTO
{
    public class Mentor : Person
    {
        public Mentor(DataRow row)
        {
            _id = (string)row["Id"];
            _name = (string)row["Name"];
            _phone = (string)row["Phone"];
            _role = (string)row["Role"];
            var clas = row["Class"];
            if (clas.ToString() != "")
                _class = (string)clas;
            //_class = (string)row["Class"];
        }
        public Mentor(string id, string name, string phone, string role, string clas)
        {
            _id = id;
            _name = name;
            _phone = phone;
            _role = role;
            _class = clas;
        }

    }
}
