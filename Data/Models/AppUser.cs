using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Data.Models
{
    public class AppUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public bool IsLibrarian { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
