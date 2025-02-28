using System;
using System.ComponentModel.DataAnnotations;

namespace vivustore.mvc.Models;

public class Supplier : User
{
    public virtual ICollection<Product> Products { get; set; } = [];

}
