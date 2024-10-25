using System;
using System.ComponentModel.DataAnnotations;

namespace Bootcamp.Models;

public class MsEmployee
{
    [Key]
    [MaxLength(36)]
    public string EmployeeId { get; set; } // employee_id

    [MaxLength(200)]
    public string Name { get; set; } // name

    [MaxLength(4000)]
    public string Position { get; set; } // position

    [MaxLength(100)]
    public string Email { get; set; } // email

    [MaxLength(36)]
    public string PhoneNumber { get; set; } // phone_number
}
