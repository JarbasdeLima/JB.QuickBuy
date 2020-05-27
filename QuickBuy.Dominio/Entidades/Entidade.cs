using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public abstract class Entidade
    {
        public List<string> _menssagensValidacao { get; set; }
        private  List<string> menssagemValidacao
        {
            get { return _menssagensValidacao ?? (_menssagensValidacao = new List<string>()); }
        }

        protected void LimparMenssagemValidacao()
        {
            menssagemValidacao.Clear();
        }
        protected void AdicionarCritica(string menssagem)
        {
            menssagemValidacao.Add(menssagem);
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get { return !menssagemValidacao.Any(); }
        }
    }
}
