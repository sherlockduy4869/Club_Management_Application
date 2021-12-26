using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    class ImplementFunction
    {
        public int startRemoving(IPersonDAL personDAL, string id, string role)
        {
            int i = personDAL.remove(id, role);
            return i;
        }
        public int startAdding(IPersonDAL personDAL, string name, string clas, string phone, string team)
        {
            int i = personDAL.addNew(name, clas, phone, team);
            return i;
        }
    }
}
