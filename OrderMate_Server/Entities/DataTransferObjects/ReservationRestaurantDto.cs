using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class ReservationRestaurantDto
    {
        public int ReservationRestaurantId { get; set; }
        public int ReservationIdFk { get; set; }
        public int RestaurantIdFk { get; set; }
    }
}
