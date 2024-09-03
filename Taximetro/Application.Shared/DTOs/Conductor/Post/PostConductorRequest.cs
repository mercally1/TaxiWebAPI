using System.ComponentModel.DataAnnotations;

namespace Application.Shared.DTOs.Conductor.Post;

public class PostConductorRequest
{
    [Required]
    public int ConductorId { get; set; }
}
