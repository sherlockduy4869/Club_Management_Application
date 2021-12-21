using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DTO
{
    public abstract class Person
    {
        protected string _id;
        protected string _name;
        protected string _phone;
        protected string _role;
        protected string _class;
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
