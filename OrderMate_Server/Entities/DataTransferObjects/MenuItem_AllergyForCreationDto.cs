using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class MenuItem_AllergyForCreationDto
    {
        public int MenuItemIdFk { get; set; }
        public int AllergyIdFk { get; set; }
    }
}
