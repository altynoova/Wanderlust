using System.ComponentModel.DataAnnotations;

namespace Travel2.Models
{
    public class Book
    {
        public int Id { get; set; } 
        public string? UserName { get; set; }
        [Required]
        public string? Usermail { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        public string? TypeOfTour { get; set; }
        public string? Message { get; set; }
        public DateTime? DateOfTour { get; set; }
        
    }
}
