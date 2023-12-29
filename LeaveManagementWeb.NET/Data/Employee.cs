using Microsoft.AspNetCore.Identity;

namespace LeaveManagementWeb.NET.Data
{
    public class Employee:IdentityUser
    {
        public string? FirstName { get; set; } // ? allowed to be null in DB
        public string? LastName { get; set; }
        public string? TaxId { get; set; }
        public DateTime DateOfBirth {  get; set; }  
        public DateTime DateJoined { get; set; }    

    }
}
