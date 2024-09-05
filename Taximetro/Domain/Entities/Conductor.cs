
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Conductor
{
    [Key]
    public int ConductorId { get; set; }

    [Required, MaxLength(100)]
    public string? Nombre { get; set; }

    [Required, MaxLength(100)]
    public string? Apellido { get; set; }

    [Required, MaxLength(30)]
    public int Licencia { get; set; } 

    [Required, MaxLength(30)]
    public int Contacto { get; set; }
}
