using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TypicalTools.Models
{
    // Admin class that sets values of an admin 
    public class Admin
    {
        [Key] public int AdminId { get; set; } 
        public string Username { get; set; }
        public string SessionId { get; set; }
        public int Role { get; set; }

        // Sets password restrictions and hides password characters when typed in
        [Column("Password")]
        [StringLength(100)]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
