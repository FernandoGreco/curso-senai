using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastroPessoa.Interfaces;

namespace cadastroPessoa.Classes
{
    public class PessoaFIsica : Pessoa, IPessoaFisica
    {

        public string? Cpf { get; set; }

        public DateTime dataNasc { get; set; }


        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
                return true;
            else
                return false;

        }

        public bool ValidarDataNasc(string dataNasc)
        {

            DateTime dataCovertida;

            if (DateTime.TryParse(dataNasc, out dataCovertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataCovertida).TotalDays / 365;

                if (anos >= 18)
                    return true;
                else
                    return false;
            }
            return false;


        }
    }
}
