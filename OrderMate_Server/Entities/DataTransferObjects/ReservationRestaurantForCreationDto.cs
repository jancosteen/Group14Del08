using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class ReservationRestaurantForCreationDto
    {
        public int ReservationIdFk { get; set; }
        public int RestaurantIdFk { get; set; }
    }
}
