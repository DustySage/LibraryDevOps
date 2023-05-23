using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Data.Models
{
    public class Loan
    {
        public int Id { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public string? PatronId { get; set; }
        [Required]
        public DateTime CheckoutDate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; }
        [Required]
        public Book? Book { get; set; }
        [Required]
        public Patron? Patron { get; set; }
    }
}