using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class MenuItem_SpecialDetailsDto
    {
        public int MenuItemSpecialId { get; set; }
        public int SpecialIdFk { get; set; }
        public int MenuItemIdFk { get; set; }

        public virtual MenuItemDto MenuItemIdFkNavigation { get; set; }
        public virtual SpecialDto SpecialIdFkNavigation { get; set; }
    }
}
