using System;
using System.Collections.Generic;

namespace Letter.Models
{
    public class Predicado
    {
        public List<string> verbo { get; set; }
        public List<string> preposicao { get; set; }
        public List<string> adverbio { get; set; }
        public List<string> adjetivo { get; set; }
        public List<string> interjeicao { get; set; }
        public List<string> numeral { get; set; }
        public List<string> conjuncao { get; set; }
        public List<string> substantivo { get; set; }
        public List<string> pronome { get; set; }
        public List<string> artigo { get; set; }

        public Predicado() { }

        public Predicado(String verbo, String preposicao, String adverbio, String adjetivo, String interjeicao, String numeral, String conjuncao, String substantivo, String artigo, String pronome)
        {
            this.verbo = new List<string>();
            this.preposicao = new List<string>();
            this.adverbio = new List<string>();
            this.adjetivo = new List<string>();
            this.interjeicao = new List<string>();
            this.numeral = new List<string>();
            this.conjuncao = new List<string>();
            this.substantivo = new List<string>();
            this.pronome = new List<string>();
            this.artigo = new List<string>();
            this.verbo.Add(verbo);
            this.preposicao.Add(preposicao);
            this.adjetivo.Add(adjetivo);
            this.adverbio.Add(adverbio);
            this.interjeicao.Add(interjeicao);
            this.numeral.Add(numeral);
            this.conjuncao.Add(conjuncao);
            this.substantivo.Add(substantivo);
            this.pronome.Add(pronome);
            this.artigo.Add(artigo);
        }
    }
}
