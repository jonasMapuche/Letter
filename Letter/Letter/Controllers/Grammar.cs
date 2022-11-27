using Letter.Models;
using Letter.Services;
using System;

namespace Letter.Controllers
{
    public class Grammar
    {
        public static readonly LetterService _lettersService = new LetterService();

        public String GetSentenceSimple(string lesson)
        {
            Aula aula = _lettersService.GetSentenceSimple(lesson);
            String pronome = aula.conteudo.pronome[0].ToString();
            String verbo = aula.conteudo.verbo[0].ToString();
            String substantivo = aula.conteudo.substantivo[0].ToString();
            String saida = pronome + " " + verbo + " " + substantivo;
            return saida;
        }
    }
}
