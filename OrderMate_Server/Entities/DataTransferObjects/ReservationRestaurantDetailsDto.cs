using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class ReservationRestaurantDetailsDto
    {
        public int ReservationRestaurantId { get; set; }
        public int ReservationIdFk { get; set; }
        public int RestaurantIdFk { get; set; }

        public virtual ReservationDto ReservationIdFkNavigation { get; set; }
        public virtual RestaurantDto RestaurantIdFkNavigation { get; set; }
    }
}
