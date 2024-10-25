using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bootcamp.Models;

public class MsCustomer
{
    [Key]
    [MaxLength(36)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string CustomerId { get; set; }

    [MaxLength(100)]
    public string Email { get; set; }

    [MaxLength(100)]
    public string Password { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(50)]
    public string PhoneNumber { get; set; }

    [MaxLength(500)]
    public string Address { get; set; }

    [MaxLength(100)]
    public string DriverLicenseNumber { get; set; }


}
