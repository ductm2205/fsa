using System;
using System.ComponentModel.DataAnnotations;
using quizzapp.api.Model.Base;
using quizzapp.api.Utils;

namespace quizzapp.api.Model.Common;

public class Question : BaseEntity
{
    [Required]
    [StringLength(500)]
    [MinLength(5)]
    public required string Content { get; set; }

    [Required]
    public required QuestionType QuestionType { get; set; }


    public Guid QuizzId { get; set; }

    public Quizz Quizz { get; set; }

    public ICollection<Answer> Answers { get; set; }
}
