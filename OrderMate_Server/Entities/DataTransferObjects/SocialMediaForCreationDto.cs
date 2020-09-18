using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class SocialMediaForCreationDto
    {
        public int SocialMediaTypeIdFk { get; set; }
        public string SocialMediaAddress { get; set; }
    }
}
