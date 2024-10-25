using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bootcamp.Models;

public class TrRental
{
    [Key]
    [MaxLength(36)]
    public string RentalId { get; set; } // rental_id

    public DateTime RentalDate { get; set; } // rental_date

    public DateTime ReturnDate { get; set; } // return_date

    [Column(TypeName = "decimal(10, 2)")]
    public decimal TotalPrice { get; set; } // total_price

    public bool PaymentStatus { get; set; } // payment_status

    [MaxLength(36)]
    public string CustomerId { get; set; } // customer_id

    [MaxLength(36)]
    public string CarId { get; set; } // car_id

    [ForeignKey("CustomerId")]
    public virtual MsCustomer Customer { get; set; } // Navigation property

    [ForeignKey("CarId")]
    public virtual MsCar Car { get; set; } // Navigation property
}
