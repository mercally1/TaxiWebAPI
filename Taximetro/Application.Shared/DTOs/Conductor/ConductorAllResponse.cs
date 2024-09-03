namespace Application.Shared.DTOs.Conductor;

public class ConductorAllResponse
{
    public int ConductorId { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int Licencia { get; set; }

    public int Contacto { get; set; }
}
