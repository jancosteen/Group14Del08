using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class MenuItemDetailsDto
    {
        public int MenuItemId { get; set; }
        public string MenuItemName { get; set; }
        public string MenuItemDescription { get; set; }
        public int? MenuItemCategoryIdFk { get; set; }
        public int? MenuItemPriceIdFk { get; set; }

        public virtual MenuItemCategoryDto MenuItemCategoryIdFkNavigation { get; set; }
        public virtual MenuItem_PriceDto MenuItemPriceIdFkNavigation { get; set; }
        public virtual ICollection<MenuItem_ItemTypeDto> ItemTypeMenuMenuItem { get; set; }
        public virtual ICollection<MenuItem_AllergyDto> MenuItemAllergy { get; set; }
        public virtual ICollection<MenuItem_SpecialDto> MenuItemSpecial { get; set; }
        //public virtual ICollection<MenuRestaurant> MenuRestaurant { get; set; }
        public virtual ICollection<Order_LineDto> OrderLine { get; set; }
    }
}
