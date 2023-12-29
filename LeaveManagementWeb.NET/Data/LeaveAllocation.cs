using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.NET.Data
{
    public class LeaveAllocation: BaseEntity
    {      
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; } //It also will allow me to get details and facilitate inner joins much more easily.

        public int LeaveTypeId { get; set; }  //So remember that we need to allocate this leave type to an employee and we're giving them that number of days

        public string EmployeeId { get; set; }

    }
}
