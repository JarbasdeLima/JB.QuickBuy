using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio
{
    public class Cliente
    {
        public Cliente()
        {
            var UsuarioRepositorio = new UsuarioRepositorio();
            var Usuario = new Usuario();

            UsuarioRepositorio.Adicionar(Usuario);
        }
    }
}
