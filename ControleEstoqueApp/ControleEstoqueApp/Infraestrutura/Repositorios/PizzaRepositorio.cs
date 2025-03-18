using ControleEstoqueApp.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControleEstoqueApp.Infraestrutura.Repositorios
{
    public class PizzaRepositorio
    {
        private static List<Pizza> pizzas = new List<Pizza>();

        public void Adicionar(Pizza pizza)
        {
            pizzas.Add(pizza);
        }

        public List<Pizza> ObterTodas()
        {
            return pizzas;
        }

        public Pizza ObterPorNome(string nome)
        {
            return pizzas.Find(p => p.NomePizza == nome);
        }

        public bool ExistePizza(string nome)
        {
            return pizzas.Exists(p => p.NomePizza == nome);
        }
    }
}
