using System;
using System.ComponentModel.DataAnnotations;

namespace vivustore.mvc.Models;

public class Category : BaseEntity
{
    [Required]
    [StringLength(255)]
    public required string Name { get; set; }

    [StringLength(255)]
    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = [];
}
