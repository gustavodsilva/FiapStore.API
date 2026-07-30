using Core.Entity;
using Core.Repository;

namespace Infraestructure.Repository;

public class PedidoRepository : EFRepository<Pedido>, IPedidoRepository
{
    public PedidoRepository(ApplicationDbContext context) : base(context)
    {

    }
}
