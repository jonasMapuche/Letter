namespace Letter.Models
{
    public class Oracao
    {
        public Sujeito sujeito { get; set; }
        public Predicado predicado { get; set; }

        public Oracao() { }

        public Oracao(Sujeito sujeito, Predicado predicado)
        {
            this.sujeito = sujeito;
            this.predicado = predicado;
        }
    }
}
