using System;
using System.Collections.Generic;

namespace Letter.Models
{
    public class Sujeito
    {
        public List<String> substantivo { get; set; }
        public List<String> pronome { get; set; }
        public List<String> artigo { get; set; }

        public Sujeito() { }

        public Sujeito(String substantivo, String pronome, String artigo)
        {
            this.substantivo = new List<string>();
            this.pronome = new List<string>();
            this.artigo = new List<string>();
            this.substantivo.Add(substantivo);
            this.pronome.Add(pronome);
            this.artigo.Add(artigo);
        }
    }
}
