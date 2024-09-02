using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Taxi
{
    [Key]
    public int TaxiId { get; set; }

    [Required]
    public int ConductorId { get; set; }

    [Required, MaxLength(10)]
    public string? Placa { get; set; }

    [Required, MaxLength(20)]
    public string? Marca { get; set; }

    [Required, MaxLength(20)]
    public string? Modelo { get; set; }

    [Required, MaxLength(10)]
    public int Ahno { get; set; }

    [ForeignKey(nameof(ConductorId))]
    public virtual Conductor? Conductor { get; set; }
}