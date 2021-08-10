using Farmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Services
{
    public interface IPedidoService
    {
        List<Pedido> all();
        public bool create(Pedido pedido);
        public Pedido get(int? id);
        public bool update(Pedido p);
        public bool delete(int? id);
    }
}
