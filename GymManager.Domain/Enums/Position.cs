using System.ComponentModel.DataAnnotations;

namespace GymManager.Domain.Enums;

public enum Position
{
    [Display(Name = "Trener personalny")]
    Trainer,

    [Display(Name = "Resepcjonista")]
    Receptionist,

    [Display(Name = "Asystent")]
    Assistance
}
