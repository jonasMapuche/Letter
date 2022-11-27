using System.Collections.Generic;

namespace Letter.Models
{
    public class Expressao
    {
        public List<Oracao> oracao { get; set; }

        public Expressao() { }

        public Expressao(Oracao oracao)
        {
            this.oracao = new List<Oracao>();
            this.oracao.Add(oracao);
        }
    }
}
