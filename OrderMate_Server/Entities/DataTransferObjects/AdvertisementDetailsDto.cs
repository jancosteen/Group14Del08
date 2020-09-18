using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class AdvertisementDetailsDto
    {
        public int AdvertisementId { get; set; }
        public string AdvertisementName { get; set; }
        public string AdvertisementDescription { get; set; }
        public byte[] AdvertisementFile { get; set; }
        public int? AdvertisementDateIdFk { get; set; }
        public int? AdvertisementPriceIdFk { get; set; }

        public virtual Advertisement_DateDto AdvertisementDateIdFkNavigation { get; set; }
        public virtual Advertisement_PriceDto AdvertisementPriceIdFkNavigation { get; set; }
        public virtual ICollection<Restaurant_AdvertisementDto> RestaurantAdvertisement { get; set; }
    }
}
