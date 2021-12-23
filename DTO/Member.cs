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
        private string _team;
        public Member(DataRow row)
        {
            _id = (string)row["Id"];
            _name = (string)row["Name"];
            _phone = (string)row["Phone"];
            _role = (string)row["Role"];
            _class = (string)row["Class"];
            _team = (string)row["Team"];
        }
        public string Team
        {
            get { return _team; }
            set { _team = value; }
        }
    }
}
