using ControleEstoqueApp.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueApp.Dominio.Servicos
{
    internal interface IPizzaDominioServico
    {
        void Validar(Pizza pizza);
        void ValidarId(int id);
    }
}
