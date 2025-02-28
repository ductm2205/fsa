using System;
using System.ComponentModel.DataAnnotations;
using quizzapp.api.Model.Base;

namespace quizzapp.api.Model.Common;

public class Answer : BaseEntity
{
    [Required]
    [StringLength(255)]
    [MinLength(5)]
    public required string Content { get; set; }

    public bool IsCorrect { get; set; } = false;

    public Guid QuestionId { get; set; }

    public Question Question { get; set; }
}
