using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class 
    {
        //Adicionar
        void Adicionar(TEntity entity);
        //Obter
        TEntity ObterPorId(int id);
        //Atualizar
        IEnumerable<TEntity> ObterTodos();
        //Remover 
        void Remover(TEntity entity);
    }
}
