using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bootcamp.Models;

public class MsCarImages
{
    [Key]
    [MaxLength(36)]
    public string ImageCarId { get; set; } // image_car_id

    [MaxLength(36)]
    public string CarId { get; set; } // car_id

    [MaxLength(2000)]
    public string ImageLink { get; set; } // image_link

    [ForeignKey("CarId")]
    public virtual MsCar Car { get; set; } // Navigation property
}
