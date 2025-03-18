using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Infraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.ControleEstoqueApp.Servicos
{
    public class PedidoService
    {
        private readonly PedidoRepositorio _pedidoRepositorio;
        private readonly PizzaRepositorio _pizzaRepositorio;

        public PedidoService(PedidoRepositorio pedidoRepositorio, PizzaRepositorio pizzaRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;
            _pizzaRepositorio = pizzaRepositorio;
        }

        public void FazerPedido(string nomeCliente, string nomePizza, int quantidade)
        {
            if (string.IsNullOrEmpty(nomeCliente))
            {
                throw new Exception("O nome do cliente não pode ser vazio.");
            }

            if (quantidade <= 0)
            {
                throw new Exception("A quantidade deve ser maior que zero.");
            }

            var pizza = _pizzaRepositorio.ObterPorNome(nomePizza);
            if (pizza == null)
            {
                throw new Exception("Pizza não encontrada.");
            }

            var pedido = new Pedido(nomeCliente, pizza, quantidade);
            _pedidoRepositorio.Adicionar(pedido);
        }

        public List<Pedido> ObterTodosPedidos()
        {
            return _pedidoRepositorio.ObterTodos();
        }
    }
}