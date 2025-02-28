using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace vivustore.mvc.Models;

public class OrderDetails
{
    public Guid OrderId { get; set; }

    public virtual Order? Order { get; set; }
    public Guid ProductId { get; set; }

    public virtual Product? Product { get; set; }

    public int Quantity { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    [Column(TypeName = "decimal(3,2)")]
    public decimal Discount { get; set; }

}
