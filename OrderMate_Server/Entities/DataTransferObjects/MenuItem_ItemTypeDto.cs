﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class MenuItem_ItemTypeDto
    {
        public int ItemTypeMenuItemId { get; set; }
        public int MenuItemIdFk { get; set; }
        public int MenuItemTypeIdFk { get; set; }
    }
    
}
