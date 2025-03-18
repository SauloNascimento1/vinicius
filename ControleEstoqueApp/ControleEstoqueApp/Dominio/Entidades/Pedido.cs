using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControleEstoqueApp.Dominio.Entidades
{
    public class Pedido
    {
        public string NomeCliente { get; set; }
        public Pizza Pizza { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataHora { get; set; }

        public Pedido(string nomeCliente, Pizza pizza, int quantidade)
        {
            NomeCliente = nomeCliente;
            Pizza = pizza;
            Quantidade = quantidade;
            ValorTotal = pizza.Preco * quantidade;
            DataHora = DateTime.Now;
        }
    }
}