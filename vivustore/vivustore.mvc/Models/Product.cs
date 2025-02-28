using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vivustore.mvc.Models;

public class Product : BaseEntity
{
    [Required]
    [StringLength(255)]
    public required string Name { get; set; }

    [StringLength(255)]
    public string? Description { get; set; }
    
    public string? Thumbnail { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }


    public Guid CategoryId { get; set; }

    public Category? Category { get; set; }

    public Guid SuplierId { get; set; }

    public Supplier? Supplier { get; set; }
}
