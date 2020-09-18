using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class UserComment
    {
        public int UserCommentId { get; set; }
        public string UserComment1 { get; set; }
        public DateTime UserCommentDateCreated { get; set; }
        public int? RestaurantIdFk { get; set; }
        public int? StarRatingIdFk { get; set; }

        public virtual Restaurant RestaurantIdFkNavigation { get; set; }
        public virtual StarRating StarRatingIdFkNavigation { get; set; }
    }
}
