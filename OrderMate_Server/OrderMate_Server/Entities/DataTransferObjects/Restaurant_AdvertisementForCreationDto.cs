﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class Restaurant_AdvertisementForCreationDto
    {
        public int RestaurantIdFk { get; set; }
        public int AdvertisementIdFk { get; set; }
    }
}
