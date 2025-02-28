using System;
using System.ComponentModel.DataAnnotations;
using quizzapp.api.Model.Base;

namespace quizzapp.api.Model.Common;

public class Quizz : BaseEntity
{
    [Required]
    [StringLength(255)]
    [MinLength(5)]
    public required string Title { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [MaxLength(3600)]
    [MinLength(0)]
    public required int Duration { get; set; }

    [StringLength(500)]
    public string? ThumbnailUrl { get; set; }


    public ICollection<Question> Questions { get; set; } = [];

}
