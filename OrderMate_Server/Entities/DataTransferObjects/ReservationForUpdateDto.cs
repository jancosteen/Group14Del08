using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class ReservationForUpdateDto
    {
        public DateTime ReservationDateCreated { get; set; }
        public DateTime ReservationDateReserved { get; set; }
        public int ReservationPartyQty { get; set; }
        public string UserIdFk { get; set; }
        public int? ReservationStatusIdFk { get; set; }
        public int ReservationNumberOfBills { get; set; }

    }
}
