using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroPessoa.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNasc(DateTime dataNasc);
    }
}