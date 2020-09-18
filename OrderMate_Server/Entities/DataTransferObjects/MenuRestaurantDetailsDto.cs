using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class MenuRestaurantDetailsDto
    {
        public int MenuRestaurantId { get; set; }
        public int MenuIdFk { get; set; }
        public int RestaurantIdFk { get; set; }
        public int? MenuItemIdFk { get; set; }

        public virtual MenuDto MenuIdFkNavigation { get; set; }
        public virtual MenuItemDto MenuItemIdFkNavigation { get; set; }
        public virtual RestaurantDto RestaurantIdFkNavigation { get; set; }
    }
}
