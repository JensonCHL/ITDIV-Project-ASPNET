using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bootcamp.Models;

public class LtPayment
{
    [Key]
    [MaxLength(36)]
    public string PaymentId { get; set; } // payment_id

    public DateTime PaymentDate { get; set; } // payment_date

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Amount { get; set; } // amount

    [MaxLength(100)]
    public string PaymentMethod { get; set; } // payment_method

    [MaxLength(36)]
    public string RentalId { get; set; } // rental_id

    [ForeignKey("RentalId")]
    public virtual TrRental Rental { get; set; } // Navigation property

}
