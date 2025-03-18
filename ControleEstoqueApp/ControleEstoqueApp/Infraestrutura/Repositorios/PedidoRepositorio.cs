using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControleEstoqueApp.Dominio.Entidades;

namespace ControleEstoqueApp.Infraestrutura.Repositorios
{
    public class PedidoRepositorio
    {
        private static List<Pedido> pedidos = new List<Pedido>();

        public void Adicionar(Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        public List<Pedido> ObterTodos()
        {
            return pedidos;
        }
    }
}