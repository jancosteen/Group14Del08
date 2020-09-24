﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class Restaurant_StatusDetailsDto
    {
        public int RestaurantStatusId { get; set; }
        public string RestaurantStatus1 { get; set; }
        public int? RestaurantIdFk { get; set; }

        public virtual ICollection<RestaurantDto> Restaurant { get; set; }
    }
}
