using FluentValidation;
using View.ViewModels;

namespace View.ViewModels.Validators 
{
    public class VolunteerViewModelValidator : AbstractValidator<VolunteerViewModel>
    {
        public VolunteerViewModelValidator()
        {
            RuleFor(volunteer => volunteer.FullName)
               .NotEmpty().WithMessage("El nombre completo es obligatorio.")
               .MaximumLength(100).WithMessage("El nombre completo no puede exceder los 100 caracteres.");
            
            RuleFor(volunteer => volunteer.Email)
                .NotEmpty().WithMessage("El email es obligatorio.")
                .EmailAddress().WithMessage("El formato del email no es válido.")
                .MaximumLength(100).WithMessage("El email no puede exceder los 100 caracteres.");
            
            RuleFor(volunteer => volunteer.PhoneNumber)
                .NotEmpty().WithMessage("El número de teléfono es obligatorio.")
                .Matches(@"^\d{7,15}$").WithMessage("El número de teléfono debe contener entre 7 y 15 dígitos numéricos.")
                .MaximumLength(15).WithMessage("El número de teléfono no puede exceder los 15 dígitos.");
            
            RuleFor(volunteer => volunteer.BirthDate)
                .NotNull().WithMessage("La fecha de nacimiento es obligatoria.")
                .LessThan(DateTime.Now).WithMessage("La fecha de nacimiento debe ser en el pasado.") 
                .Must(BeAValidAge).WithMessage("El voluntario debe tener al menos 16 años."); 
            
            RuleFor(volunteer => volunteer.SkillsAndExperience)
                .MaximumLength(500).WithMessage("Las habilidades y experiencia no pueden exceder los 500 caracteres.");            
        }

        private bool BeAValidAge(DateTime birthDate)
        {            
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;

            return age >= 18; 
        }
    }
}