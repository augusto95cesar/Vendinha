using System.ComponentModel.DataAnnotations.Schema;

namespace Vendinha.Domain;
public class Divida
{
    public int Id { get; set; }
    public bool Pago { get; set; }
    public DateTime? DataInicial { get; set; }
    public DateTime? DataPagamento { get; set; }

    public int IdCliente { get; set; }

    [ForeignKey(nameof(IdCliente))]
    public virtual Cliente Cliente { get; set; }
}
