using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int Gender { get; set; }
        public string Password { get; set; }

    }
}
