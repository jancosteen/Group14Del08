using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class StarRating
    {
        public StarRating()
        {
            UserComment = new HashSet<UserComment>();
        }

        public int StarRatingId { get; set; }
        public int StarRatingValue { get; set; }

        public virtual ICollection<UserComment> UserComment { get; set; }
    }
}
