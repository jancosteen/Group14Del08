using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class Seating_LayoutForCreationDto
    {
        public int RestaurantIdFk { get; set; }
        public int LayoutTypeIdFk { get; set; }
        public string SeatingLayoutQty { get; set; }
    }
}
