using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class ReservationDetailsDto
    {
        public int ReservationId { get; set; }
        public DateTime ReservationDateCreated { get; set; }
        public DateTime ReservationDateReserved { get; set; }
        public int ReservationPartyQty { get; set; }
        public string UserIdFk { get; set; }
        public int? ReservationStatusIdFk { get; set; }
        public int ReservationNumberOfBills { get; set; }

        public virtual ReservationStatusDto ReservationStatusIdFkNavigation { get; set; }
        public virtual AspNetUsers UserIdFkNavigation { get; set; }
        //public virtual ICollection<ReservationRestaurant> ReservationRestaurant { get; set; }
        public virtual ICollection<SeatingDto> Seating { get; set; }

    }
}
