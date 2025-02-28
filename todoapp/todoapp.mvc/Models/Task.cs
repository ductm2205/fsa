namespace todoapp.mvc.Models;

public class Task : BaseEntity
{

    public required string Name { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }

    public int CategoryId { get; set; }

    public Category? Category { get; set; }
}
