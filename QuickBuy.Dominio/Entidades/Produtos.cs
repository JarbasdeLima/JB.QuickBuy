using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public class Produtos : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Críticas - Nome produto inválido.");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Críticas - Descrição produto inválido.");

            if (Preco <= 0)
                AdicionarCritica("Críticas - Preço incorreto.");
        }
    }
}
