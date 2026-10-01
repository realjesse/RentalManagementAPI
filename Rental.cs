using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalManagementAPI;

public class Rental
{
    public int Id { get; set; } // Primary Key
    public int CustomerId { get; set; } // Foreign Key
    public int MovieId { get; set; } // Foreign Key
    public DateTime RentalDate { get; set; } = DateTime.UtcNow; // Default to now upon renting
    public DateTime? ReturnDate { get; set; } = null; // Default to none (entity is created on renting)
}