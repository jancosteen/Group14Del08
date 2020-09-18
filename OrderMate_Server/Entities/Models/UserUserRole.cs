using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class UserUserRole
    {
        public int UserUserRoleId { get; set; }
        public string UserIdFk { get; set; }
        public int UserRoleIdFk { get; set; }

        public virtual AspNetUsers UserIdFkNavigation { get; set; }
    }
}
