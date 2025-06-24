
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class VolunteerAvailability
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El ID del voluntario es obligatorio.")] 
        public int VolunteerId { get; set; }

        [Required(ErrorMessage = "El día de la semana es obligatorio.")]
        public DayOfWeek DayOfWeek { get; set; }

        [Required(ErrorMessage = "La hora de inicio es obligatoria.")]
        public TimeSpan StartTime { get; set; }

        [Required(ErrorMessage = "La hora de finalización es obligatoria.")]
        public TimeSpan EndTime { get; set; }
        
        public virtual Volunteer Volunteer { get; set; }
    }
}
