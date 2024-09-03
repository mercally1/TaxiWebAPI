using System.ComponentModel.DataAnnotations;

namespace Application.Shared.DTOs.Conductor.Get;

public class GetConductorAllRequest
{
    [Required]
    public int ConductorId { get; set; }
}
