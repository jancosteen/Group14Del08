using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class MenuForUpdateDto
    {
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
        public DateTime MenuDateCreated { get; set; }
        public DateTime? MenuTimeActiveFrom { get; set; }
        public DateTime? MenuTimeActiveTo { get; set; }
    }
}
