﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class RestaurantRestaurantImageForCreationDto
    {
        public int RestaurantIdFk { get; set; }
        public int RestaurantImageIdFk { get; set; }
        public int RestaurantRestaurantImageId { get; set; }
    }
}