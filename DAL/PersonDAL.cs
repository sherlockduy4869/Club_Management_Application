using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    interface PersonDAL
    {
        public int addNew(string id, string name, string clas, string phone);
        public int remove(string id, string role);

    }
}
