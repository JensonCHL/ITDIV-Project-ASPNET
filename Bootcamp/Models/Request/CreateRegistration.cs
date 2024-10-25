using System;
using System.ComponentModel.DataAnnotations;

namespace Bootcamp.Models.Request;

public class CreateRegistration
{   
    [Required]
    
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public string Address { get; set; }


}
