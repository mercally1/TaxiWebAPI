using Domain.Entities;

namespace Domain.Interfaces.Infrastructure.Repositories
{
    public interface IConductorRepository
    {
        Task<Conductor> GetAllConductorAsync(int ConductorId);

        Task<Conductor> GetConductorAsync(int ConductorId);

        Task<bool> AddConductorAsync(Conductor conductor);

        Task<Conductor> ModifyConductorAsync(Conductor conductorId);

        Task<bool> RemoveConductorAsync(int conductorId);
    }
}
