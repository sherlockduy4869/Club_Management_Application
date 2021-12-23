using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DTO
{
    public class Activity
    {
        private string _id;
        private string _name;
        private string _dateStart;
        private string _dateEnd;
        public Activity(DataRow row)
        {
            _id = (string)row["Id"];
            _name = (string)row["Name"];
            _dateStart = (string)row["DateStart"];
            _dateEnd = (string)row["DateEnd"];
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
        public string DateStart
        {
            get { return _dateStart; }
            set { _dateStart = value; }
        }
        public string DateEnd
        {
            get { return _dateEnd; }
            set { _dateEnd = value; }
        }
    }
}
