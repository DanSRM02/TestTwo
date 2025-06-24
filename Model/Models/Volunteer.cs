using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Volunteer 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre completo es obligatorio.")] 
        public string FullName { get; set; } 

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        public DateTime BirthDate { get; set; } 

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")] 
        public string Email { get; set; }

        [Required(ErrorMessage = "Las habilidades y experiencia son obligatorias.")]
        public string SkillsAndExperience { get; set; } 

        [Required(ErrorMessage = "El número de teléfono es obligatorio.")]
        public string Phone { get; set; }
        
        public virtual ICollection<VolunteerAvailability> Availabilities { get; set; } = new List<VolunteerAvailability>();


    }
}
