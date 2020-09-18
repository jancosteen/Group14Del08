using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class Restaurant_Type_RefDto
    {
        public int RestaurantTypeRefId { get; set; }
        public int RestaurantTypeIdFk { get; set; }
        public int RestaurantIdFk { get; set; }


    }
}
