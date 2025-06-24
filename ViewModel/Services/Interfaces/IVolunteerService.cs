using Domain.Models;

namespace Logic.Services.Interfaces
{
    public interface IVolunteerService 
    {
        Task Add(Volunteer volunteer);
    }
}
