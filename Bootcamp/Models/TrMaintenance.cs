using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bootcamp.Models;

public class TrMaintenance
{
    [Key]
    [MaxLength(36)]
    public string MaintenanceId { get; set; }

    public DateTime MaintenanceDate { get; set; } 

    [MaxLength(400)]
    public string Description { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Cost { get; set; } 

    [MaxLength(36)]
    public string CarId { get; set; } 

    [MaxLength(36)]
    public string EmployeeId { get; set; }

    [ForeignKey("CarId")]
    public virtual MsCar Car { get; set; } 

    [ForeignKey("EmployeeId")]
    public virtual MsEmployee Employee { get; set; } 
}
