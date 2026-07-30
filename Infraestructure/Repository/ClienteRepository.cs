using Core.Entity;
using Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository;

public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
{
    public ClienteRepository(ApplicationDbContext context) : base(context)
    {

    }

    public Cliente ObterPedidoSeisMeses(int id)
    {
        var cliente = _context.Clientes
            .Include(c => c.Pedidos)
                .ThenInclude(p => p.Livro)
            .FirstOrDefault(c => c.Id == id)
            ?? throw new Exception("Esse cliente não existe");
        cliente.Pedidos = cliente.Pedidos.Where(c=> c.DataCriacao >= DateTime.Now.AddMonths(-6)).ToList();
        return cliente;
    }
}
