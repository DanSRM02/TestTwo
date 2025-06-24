using DataAccess.Interfaces;
using Domain.Models;
using Logic.Services.Interfaces;

namespace Logic.Services
{
    public class VolunteerService : IVolunteerService
    {
        private readonly IVolunteerRepository _volunteerRepository;
        public VolunteerService(IVolunteerRepository volunteerRepository)
        {
            _volunteerRepository = volunteerRepository;
        }

        async public Task Add(Volunteer volunteer)
        {
            try
            {                
                await _volunteerRepository.Add(volunteer);                
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while adding the volunteer.", ex);
            }
        }

    }
}
