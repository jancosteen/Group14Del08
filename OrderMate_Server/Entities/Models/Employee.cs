using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Employee
    {
        public Employee()
        {
           // User = new HashSet<User>();
            AttendanceSheet = new HashSet<AttendanceSheet>();
            EmployeeShift = new HashSet<EmployeeShift>();
            ProductStockTake = new HashSet<ProductStockTake>();
            ProductWrittenOff = new HashSet<ProductWrittenOff>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeIdNumber { get; set; }
        public int? RestaurantIdFk { get; set; }

        public virtual Restaurant RestaurantIdFkNavigation { get; set; }
        public virtual ICollection<User> AspNetUsers { get; set; }
        public virtual ICollection<AttendanceSheet> AttendanceSheet { get; set; }
        public virtual ICollection<EmployeeShift> EmployeeShift { get; set; }
        public virtual ICollection<ProductStockTake> ProductStockTake { get; set; }
        public virtual ICollection<ProductWrittenOff> ProductWrittenOff { get; set; }
    }
}
