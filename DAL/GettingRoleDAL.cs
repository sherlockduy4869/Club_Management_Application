using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    class GettingRoleDAL
    {
        public static IPersonDAL getRoleForRemoving(string role)
        {
            if(role == "Member")
            {
                return new MemberDAL();
            }
            else if (role == "Leader")
            {
                return new LeaderDAL();
            }
            else 
            
            return new MentorDAL();   
        }
        public static IPersonDAL getRoleForAdding(string role)
        {
            if (role == "Member")
            {
                return new MemberDAL();
            }
            else if (role == "Leader")
            {
                return new LeaderDAL();
            }
            else

            return new MentorDAL();
        }
    }
}
