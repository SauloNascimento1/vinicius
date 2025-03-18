using Microsoft.EntityFrameworkCore;
using ControleEstoqueApp.Dominio.Entidades;

namespace ControleEstoqueApp.Infraestrutura.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "estoque.db");
            Console.WriteLine($"Banco de dados em: {path}");
            options.UseSqlite($"Data Source={path}");
        }

    }
}