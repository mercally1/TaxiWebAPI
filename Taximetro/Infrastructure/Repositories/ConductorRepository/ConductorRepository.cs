using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.ConductorRepository;

public class ConductorRepository
{
    private readonly TaxiDbContext _taxiDbContext;

    public ConductorRepository(TaxiDbContext taxiDbContext)
    {
        _taxiDbContext = taxiDbContext;
    }
    
    //method Get
    public async Task<Conductor> GetAllConductorAsync(int ConductorId)
    {
        Conductor? conductor = await _taxiDbContext
            .conductores
            .FirstOrDefaultAsync(driver => driver.ConductorId == ConductorId)
            .ConfigureAwait(false);

        return conductor;
    }

    public async Task<Conductor> GetConductorAsync(int ConductorId) 
    {
        Conductor? conductor = await _taxiDbContext
            .conductores
            .AsNoTracking()
            .FirstOrDefaultAsync(driver => driver.ConductorId == ConductorId)
            .ConfigureAwait(false);

        return conductor;
    }

    //Method Post
    public async Task<bool> AddConductorAsync(Conductor conductor)
    {
        if (conductor != null)
            return false;

        _taxiDbContext
            .conductores
            .Add(conductor);

        int changeMade = await _taxiDbContext.SaveChangesAsync();

        return changeMade > 0 ;
    }

    //Method Put
    public async Task<Conductor> ModifyConductorAsync(Conductor conductorId)
    {
        Conductor? conductor = await _taxiDbContext
             .conductores
             .AsTraking()
             .FirstOrDefaultAsync(u => u.ConductorId == conductor.ConductorId);
         
        await _taxiDbContext.SaveChangesAsync();
    }


    //Method Delete
    public async Task<bool> RemoveConductorAsync(int conductorId)
    {
        Conductor? conductorDelete = await _taxiDbContext
            .conductores
            .FirstOrDefaultAsync(u => u.ConductorId == conductorId);

        if (conductorDelete != null)
            return false;

        int changeMade = _taxiDbContext.SaveChanges();

        return changeMade > 0;
    }
}
