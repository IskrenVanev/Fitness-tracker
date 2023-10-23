using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Fitness_Tracker.Models
{
    public class User
    {
        [Required]
        public int UserID { get; set; } // Primary Key

        public required string Username { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; } // Hashed for security
        // Other user-related fields as needed                                 
        public List<Recipe>? CreatedRecipes { get; set; }

        public List<Body>? BodyMeasurements { get; set; }
    }
}
