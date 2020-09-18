using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class MenuItem_PriceDetailsDto
    {
        public int MenuItemPriceId { get; set; }
        public double MenuItemPrice1 { get; set; }
        public DateTime MenuItemDateUpdated { get; set; }
        public string MenuItemPriceStatus { get; set; }

        public virtual ICollection<MenuItemDto> MenuItem { get; set; }
    }
}
