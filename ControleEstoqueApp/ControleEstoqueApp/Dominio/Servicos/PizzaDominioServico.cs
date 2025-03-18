
using ControleEstoqueApp.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleEstoqueApp.Dominio.Servicos.PizzaDominioServico;

namespace ControleEstoqueApp.Dominio.Servicos
{

        public class PizzaDominioServico : IPizzaDominioServico
        {
            public void Validar(Pizza pizza)
            {
                if (string.IsNullOrEmpty(pizza.NomePizza))
                {
                    throw new Exception("Nome é obrigatório");
                }
                if (pizza.Preco < 0)
                {
                    throw new Exception("Preço deve ser maior que zero");
                }
            }
            public void ValidarId(int id)
            {
                if (id <= 0)
                {
                    throw new Exception("Id inválido");
                }
            }
        }
}
