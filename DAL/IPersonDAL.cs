using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    interface IPersonDAL
    {
       int remove(string id, string role);
       int addNew(string name, string clas, string phone, string team);
    }
}
