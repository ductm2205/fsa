using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace quizzapp.api.Utils;

public enum QuestionType
{
    [Display(Name = "MultipleChoice")]
    MultipleChoice,

    [Display(Name = "SingleChoice")]
    SingleChoice,

    [Display(Name = "TrueFalse")]
    TrueFalse,

    [Display(Name = "FillInTheBlanks")]
    FillInTheBlanks,

    [Display(Name = "ShortAnswer")]
    ShortAnswer,

    [Display(Name = "LongAnswer")]
    LongAnswer,
}
