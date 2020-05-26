using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime dataPedido { get; set; }
        public int UsuarioId { get; set; }

        public ICollection <ItemPedido> ItensPedidos { get; set; }
    }
}
