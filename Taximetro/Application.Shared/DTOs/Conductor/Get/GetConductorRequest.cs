using System.ComponentModel.DataAnnotations;

namespace Application.Shared.DTOs.Conductor.Get;

public class GetConductorRequest
{
    [Required]
    public int ConductorId { get; set; }
}
