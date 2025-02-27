using System;

namespace todoapp.mvc.Models;

public class Category : BaseEntity
{
    public required string Name { get; set; }

    public string? Description { get; set; }

    public ICollection<Task> Tasks { get; set; } = [];
}
