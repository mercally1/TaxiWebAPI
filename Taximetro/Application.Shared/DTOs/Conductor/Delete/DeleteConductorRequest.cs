using System.ComponentModel.DataAnnotations;

namespace Application.Shared.DTOs.Conductor.Delete;

public class DeleteConductorRequest
{
    [Required]
    public int ConductorId { get; set; }
}
