using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class ReservationDto
    {
        public int ReservationId { get; set; }
        public DateTime ReservationDateCreated { get; set; }
        public DateTime ReservationDateReserved { get; set; }
        public int ReservationPartyQty { get; set; }
        public string UserIdFk { get; set; }
        public int? ReservationStatusIdFk { get; set; }
        public int ReservationNumberOfBills { get; set; }

    }
}
