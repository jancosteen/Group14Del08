﻿using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class UserUserImage
    {
        public int UserUserImage1 { get; set; }
        public string UserIdFk { get; set; }
        public int UserImageIdFk { get; set; }

        public virtual AspNetUsers UserIdFkNavigation { get; set; }
        public virtual UserImage UserImageIdFkNavigation { get; set; }
    }
}
