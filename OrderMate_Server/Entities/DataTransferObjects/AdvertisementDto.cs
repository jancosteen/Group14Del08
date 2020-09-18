using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class AdvertisementDto
    {
        public int AdvertisementId { get; set; }
        public string AdvertisementName { get; set; }
        public string AdvertisementDescription { get; set; }
        public byte[] AdvertisementFile { get; set; }
        public int? AdvertisementDateIdFk { get; set; }
        public int? AdvertisementPriceIdFk { get; set; }


    }
}
