namespace Intro_ASPNetMVC.Models;

public class Cliente
{
    // propiedades
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public DateTime FechaAlta { get; set; }
    public required string Email { get; set; }
}
