using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    public abstract class PersonDAL
    {
       public abstract int remove(string id, string role);
       public abstract int addNew(string name, string clas, string phone, string team);
        
    }
}
