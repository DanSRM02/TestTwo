using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Event
    {
        public int Id { get; set; }

        public int VolunteerId { get; set; }

        public Volunteer Volunteer { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public string Location { get; set; }

        [MaxLength(250)]
        [Required]
        public string Description { get; set; }

        [Range(0, 60, ErrorMessage = "The duration must be between 0 and 60 min.")]
        [Required]
        public int Duration { get; set; }


        public string SpecialRequirement { get; set; }

        [Range(0, 30, ErrorMessage = "Number of volunteers must be between 0 and 30.")]
        [Required]
        public int Volunteers { get; set; }

        [Required]
        public string OrganizerContact { get; set; }
    }
}
