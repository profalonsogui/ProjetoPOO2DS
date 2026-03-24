namespace SistemaBancario
{
    // ContaCorrente HERDA de ContaBancaria
    public class ContaCorrente : ContaBancaria
    {
        public decimal Limite { get; private set; }

        // O construtor recebe o titular e o limite desejado
        public ContaCorrente(Titular cliente, decimal limite) : base(cliente)
        {
            Limite = limite;
        }

        // Exemplo de como a Herança ajuda: 
        // Podemos criar um método de exibição específico para a Corrente
        public void ExibirDadosCorrente()
        {
            Console.WriteLine($"--- Dados Conta Corrente ---");
            Console.WriteLine($"Titular: {Dono.Nome}");
            Console.WriteLine($"Saldo Disponível: R$ {Saldo}");
            Console.WriteLine($"Limite de Crédito: R$ {Limite}");
            Console.WriteLine($"Total (Saldo + Limite): R$ {Saldo + Limite}");
        }
    }
}