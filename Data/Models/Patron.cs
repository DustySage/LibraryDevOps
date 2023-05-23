namespace LibraryManagement.Data.Models
{
    public class Patron : AppUser
    {
        public List<Loan>? Loans { get; set; }
        public List<Reservation>? Reservations { get; set; }
    }
}
