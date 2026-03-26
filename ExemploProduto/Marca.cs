namespace ExemploProduto
{
    public class Marca
    {
        public string Nome { get; }
        public double DescontoOferecido { get; } // Ex: 0.10 para 10%

        public Marca(string nome, double descontoOferecido)
        {
            Nome = nome;
            DescontoOferecido = descontoOferecido;
        }
    }
}