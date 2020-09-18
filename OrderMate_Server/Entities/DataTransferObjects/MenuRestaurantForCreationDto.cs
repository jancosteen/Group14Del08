using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class MenuRestaurantForCreationDto
    {
        public int MenuIdFk { get; set; }
        public int RestaurantIdFk { get; set; }
        public int? MenuItemIdFk { get; set; }
    }
}
