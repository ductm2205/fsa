using System;
using System.ComponentModel.DataAnnotations;

namespace vivustore.mvc.Models;

public class Order : BaseEntity
{
    [Required]
    public required DateTime OrderDate { get; set; }

    [Required]
    [StringLength(255)]
    public required string ShipAddress { get; set; }

    [Required]
    public required DateTime ExpectedShipDate { get; set; }

    public DateTime? ActualShipDate { get; set; }

}
