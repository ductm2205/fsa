using System;

namespace vivustore.mvc.Models;

public class BaseEntity
{
    public Guid Id { get; set; }

    public DateTime InsertedAt { get; set; }

    public DateTime ModifiedAt { get; set; }

    public DateTime DeletedAt { get; set; }
}
