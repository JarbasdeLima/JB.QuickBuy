using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }
        
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public ICollection <ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMenssagemValidacao();
            if (!ItensPedidos.Any())
               AdicionarCritica("Críticas - Pedido sem item selecionado");
            
            if(string.IsNullOrEmpty(Cep))
            AdicionarCritica("Críticas - Cep inválido");

        }
    }
}
