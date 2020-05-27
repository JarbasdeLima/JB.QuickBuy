using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public ICollection <Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMenssagemValidacao();
            
            if(string.IsNullOrEmpty(Email))
            AdicionarCritica("Críticas - Email inválido.");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Críticas - Senha inválida.");

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Críticas - Nome usuário inválido.");

            if (string.IsNullOrEmpty(SobreNome))
                AdicionarCritica("Críticas - Sobrenome de usuário inválido.");

        }
    }
}
