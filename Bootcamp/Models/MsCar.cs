using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bootcamp.Models;

public class MsCar
{
    [Key]
    [MaxLength(36)]
    public string CarId { get; set; } // car_id

    [MaxLength(200)]
    public string Name { get; set; } // name

    [MaxLength(100)]
    public string Model { get; set; } // model

    public int Year { get; set; } // year

    [MaxLength(50)]
    public string LicensePlate { get; set; } // license_plate

    public int NumberOfCarSeats { get; set; } // number_of_car_seats

    [MaxLength(100)]
    public string Transmission { get; set; } // transmission

    [Column(TypeName = "decimal(10, 2)")]
    public decimal PricePerDay { get; set; } // price_per_day

    public bool Status { get; set; } // status
}
