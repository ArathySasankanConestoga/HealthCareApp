using System;
using System.ComponentModel.DataAnnotations;

namespace HealthCareApp.Models  
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)] // Prevent excessively long names
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress] // Validate email format
        [MaxLength(255)] // Prevent excessively long emails
        public string Email { get; set; } = string.Empty;

        [Required] // Ensure password is always provided
        [MaxLength(500)] // Set limit for hashing storage
        public string PasswordHash { get; set; } = string.Empty;
    }
}
