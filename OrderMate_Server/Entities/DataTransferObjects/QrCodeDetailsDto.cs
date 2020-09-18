using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class QrCodeDetailsDto
    {
        public int QrCodeId { get; set; }
        public int? RestaurantIdFk { get; set; }

        public virtual RestaurantDto RestaurantIdFkNavigation { get; set; }
        public virtual ICollection<QrCode_SeatingDto> QrCodeSeating { get; set; }
    }
}
