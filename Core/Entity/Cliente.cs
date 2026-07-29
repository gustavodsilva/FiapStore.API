namespace Core.Entity;

public class Cliente : EntityBase
{
    public required string Nome { get; set; }
    public DateTime? DataNascimento { get; set; }
    public ICollection<Pedido> Pedidos { get; set; }
    public required string CPF { get; set; }
}
