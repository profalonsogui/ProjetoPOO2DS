namespace SistemaBancario
{
    // O ':' significa que ContaPoupanca HERDA tudo de ContaBancaria
    public class ContaPoupanca : ContaBancaria
    {
        // O construtor repassa o cliente para a classe base (pai)
        public ContaPoupanca(Titular cliente) : base(cliente) { }

        public void RenderJuros()
        {
            Saldo += Saldo * 0.01m; // Aumenta o saldo em 1%
        }
    }
}