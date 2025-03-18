using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ControleEstoqueApp.Dominio.Entidades
{
    public class Pizza
    {
        public string NomePizza { get; set; }
        public decimal Preco { get; set; }

        public Pizza(string nome, decimal preco)
        {
            NomePizza = nome;
            Preco = preco;
        }
    }
}