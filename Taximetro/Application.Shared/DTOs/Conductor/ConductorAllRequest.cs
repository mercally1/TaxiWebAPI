using System.ComponentModel.DataAnnotations;

namespace Application.Shared.DTOs.Conductor;

public class ConductorAllRequest
{
    [Required]
    public int ConductorId { get; set; }

    [Required]
    public string? Nombre { get; set; }

    [Required]
    public string? Apellido { get; set; }

    [Required]
    public int Licencia { get; set; }
}
