using BlazorServerApp_RelationalCRUD_DataFirst.Models;
using System.Numerics;

namespace BlazorServerApp_RelationalCRUD_DataFirst.Services
{
    public interface ITraineeService
    {
        Task<List<Trainee>> GetTraineesList();
        Task<Trainee> GetTraineeById(int id);
        Task<Trainee> CreateTrainee(Trainee trainee);
        Task UpdateTrainee(Trainee trainee);
        Task DeleteTrainee(Trainee trainee);
    }
}
