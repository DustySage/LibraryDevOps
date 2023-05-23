using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public string? Isbn { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int TotalCopies { get; set; }
        [Required]
        public int AvailableCopies { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        public List<Loan>? Loans { get; set; }
        public List<Reservation>? Reservations { get; set; }
    }
}