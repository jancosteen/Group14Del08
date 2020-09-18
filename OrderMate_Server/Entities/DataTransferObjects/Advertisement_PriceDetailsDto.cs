using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class Advertisement_PriceDetailsDto
    {
        public int AdvertisementPriceId { get; set; }
        public double AdvertismentPrice { get; set; }
        public DateTime AdvertisementPriceDateUpdated { get; set; }

        public virtual ICollection<AdvertisementDto> Advertisement { get; set; }
    }
}

