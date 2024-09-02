using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Trayecto
{
    [Key]
    public int TrayectoId { get; set; }

    [Required, MaxLength(100)]
    public string? Ubicacion_Initial {  get; set; }

    [Required, MaxLength(100)]
    public string? Ubicacion_Final { get; set; }

    [Required]
    public int TaxiId { get; set; }

    [Required, MaxLength(10)]
    public int Kilometraje { get; set; }

    [ForeignKey(nameof(TaxiId))]
    public virtual Taxi? Taxi { get; set; }
}
