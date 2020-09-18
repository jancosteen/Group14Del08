using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class RestaurantRestaurantImageDetailsDto
    {
        public int RestaurantIdFk { get; set; }
        public int RestaurantImageIdFk { get; set; }
        public int RestaurantRestaurantImageId { get; set; }

        public virtual RestaurantDto RestaurantIdFkNavigation { get; set; }
        public virtual Restaurant_ImageDto RestaurantImageIdFkNavigation { get; set; }
    }
}
