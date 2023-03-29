
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{

    [Keyless]
    public class AppEmployee
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeGroup { get; set; }
        public string OrganizationUnit { get; set; }
        public string ManagerName { get; set; }
        public string WorkSchedule { get; set; }
        
    }
}