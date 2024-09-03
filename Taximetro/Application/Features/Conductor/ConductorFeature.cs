using Application.Shared.DTOs.Conductor.Delete;
using Application.Shared.DTOs.Conductor.Get;
using Application.Shared.DTOs.Conductor.Post;
using Application.Shared.DTOs.Conductor.Put;
using Domain.Interfaces.Application.Features;
using Domain.Interfaces.Infrastructure.Repositories;

namespace Application.Features.Conductor;

public class ConductorFeature : IConductorFeature
{
    private readonly IConductorRepository _conductorRepository;

    public ConductorFeature(IConductorRepository conductorRepository)
    {
        _conductorRepository = conductorRepository;
    }

    public async Task<GetConductorAllResponse> GetAllConductorAsync(GetConductorAllRequest conductorResquest)
    {
        var conductorId = await _conductorRepository.GetAllConductorAsync(conductorResquest.ConductorId);

        return new GetConductorAllResponse()
        { 
            ConductorId = conductorResquest.ConductorId,
        };
    }

    public async Task<GetConductorResponse> GetConductorAsync(GetConductorRequest getConductorRequest)
    {
        var conductorId = await _conductorRepository.GetConductorAsync(getConductorRequest.ConductorId);

        return new GetConductorResponse()
        {
            ConductorId = getConductorRequest.ConductorId,
        };
    }

    public async Task<PostConductorResponse> CreateConductorAsync(PostConductorRequest postConductorRequest)
    {
        Domain.Entities.Conductor conductor = new Domain.Entities.Conductor()
        {
            ConductorId = postConductorRequest.ConductorId,
            Nombre = postConductorRequest.Nombre,
            Apellido = postConductorRequest.Apellido,
            Licencia = postConductorRequest.Licencia,
            Contacto = postConductorRequest.Contacto,
        };

        bool created = await _conductorRepository.AddConductorAsync(conductor);

        return new PostConductorResponse()
        {
            Success = true,
        };
    }

    public async Task<PutConductorResponse> ModifyConductorAsync(PutConductorRequest putConductorRequest)
    {
        Domain.Entities.Conductor conductor = new Domain.Entities.Conductor()
        {
            ConductorId = putConductorRequest.ConductorId,
            Nombre = putConductorRequest.Nombre,
            Apellido = putConductorRequest.Apellido,
            Licencia = putConductorRequest.Licencia,
            Contacto = putConductorRequest.Contacto,
        };

        bool created = await _conductorRepository.AddConductorAsync(conductor);

        return new PutConductorResponse()
        {
            Success = true,
        };
    }

    public async Task<DeleteConductorResponse> DeleteConductorAsync(DeleteConductorRequest deleteConductorRequest)
    {
        var conductorId = await _conductorRepository.RemoveConductorAsync(deleteConductorRequest.ConductorId);
        
        return new DeleteConductorResponse()
        {
            Success = true,
        };
    }
}
