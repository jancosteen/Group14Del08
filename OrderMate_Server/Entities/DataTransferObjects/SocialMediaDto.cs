using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class SocialMediaDto
    {
        public int SocialMediaId { get; set; }
        public int SocialMediaTypeIdFk { get; set; }
        public string SocialMediaAddress { get; set; }
    }
}
