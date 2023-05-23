using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Data.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public string? PatronId { get; set; }
        [Required]
        public DateTime ReservationDate { get; set; }
        public bool IsFulfilled { get; set; }
        [Required]
        public Book? Book { get; set; }
        [Required]
        public Patron? Patron { get; set; }
    }
}
