using System.ComponentModel.DataAnnotations.Schema;

namespace Vendinha.Domain;
public class Cliente
{
    public int Id { get; set; }
    public string? NomeCompleto { get; set; }
    public int Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public int Idade { get; private set; }
    public string? Email { get; set; } 
    public virtual List<Divida>? Dividas { get; set; }
}
