using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastroPessoa.Interfaces;
using System.Text.RegularExpressions;

namespace cadastroPessoa.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? Cnpj { get; set; }

        public string? RazaoSocial { get; set; }


        public override float PagarImposto(float rendimento)
        {
            if(rendimento <= 3000)
                return rendimento * .02f;
            else if (rendimento <= 6000)
                return rendimento * .05f;
            else if (rendimento <= 10000)
                return rendimento * .07f;
            else
                return rendimento * .09f;
        }

        //
        public bool ValidarCnpj(string cnpj)
        {
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)");

            if (retornoCnpjValido)
            {

                if (cnpj.Length == 18)
                    return (CheckMilContra(cnpj, 11));
                else if (cnpj.Length == 14)
                    return (CheckMilContra(cnpj, 8));
            }

            return false;

        }

        public bool CheckMilContra(string cnpj, int startMil)
        {
            string subString = cnpj.Substring(startMil, 4);
            
            if (subString == "0001")
                return true;
            else
                return false;
        }
    }
}
