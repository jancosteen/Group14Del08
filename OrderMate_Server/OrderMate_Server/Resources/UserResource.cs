using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderMate_Server.Resources
{
    public class UserResource
    {
        
        public string Password { get; set; }
        

       
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public string Contact_Number { get; set; }
        public string UserRoleIdFk { get; set; }
     
    }
}
