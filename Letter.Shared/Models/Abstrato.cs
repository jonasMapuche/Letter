using System;
using System.Collections.Generic;
using System.Text;

namespace Letter.Models
{
    public class Abstrato
    {
        public String nome { get; set; }
        public List<Expressao> expressao { get; set; }

        public Abstrato() { }

        public Abstrato(String nome, Expressao expressao)
        {
            this.nome = nome;
            this.expressao = new List<Expressao>();
            this.expressao.Add(expressao);
        }
    }
}
