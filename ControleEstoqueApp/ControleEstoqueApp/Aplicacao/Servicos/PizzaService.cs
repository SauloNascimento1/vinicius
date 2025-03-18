using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Infraestrutura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Aplicacao.ControleEstoqueApp.Servicos
{
    public class PizzaService
    {
        private readonly PizzaRepositorio _pizzaRepositorio;

        public PizzaService(PizzaRepositorio pizzaRepositorio)
        {
            _pizzaRepositorio = pizzaRepositorio;
        }

        public void CadastrarPizza(string nome, decimal preco)
        {
            if (_pizzaRepositorio.ExistePizza(nome))
            {
                throw new Exception("Já existe uma pizza com esse nome.");
            }

            if (preco <= 0)
            {
                throw new Exception("O preço da pizza deve ser maior que zero.");
            }

            var pizza = new Pizza(nome, preco);
            _pizzaRepositorio.Adicionar(pizza);
        }

        public List<Pizza> ObterTodasPizzas()
        {
            return _pizzaRepositorio.ObterTodas();
        }
    }
}