using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastroPessoa.Interfaces;

namespace cadastroPessoa.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome { get; set; }
        
        public float Rendimento { get; set; }
        
        public Endereco? Endereco { get; set; }

        public abstract float PagarImposto(float rendimento);
    }
}
