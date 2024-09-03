using Application.Shared.DTOs.Conductor.Delete;
using Application.Shared.DTOs.Conductor.Get;
using Application.Shared.DTOs.Conductor.Post;
using Application.Shared.DTOs.Conductor.Put;

namespace Domain.Interfaces.Application.Features;

public interface IConductorFeature
{
    Task<GetConductorAllResponse> GetAllConductorAsync(GetConductorAllRequest conductorResquest);

    Task<GetConductorResponse> GetConductorAsync(GetConductorRequest getConductorRequest);

    Task<PostConductorResponse> CreateConductorAsync(PostConductorRequest postConductorRequest);

    Task<PutConductorResponse> ModifyConductorAsync(PutConductorRequest putConductorRequest);

    Task<DeleteConductorResponse> DeleteConductorAsync(DeleteConductorRequest deleteConductorRequest);
}