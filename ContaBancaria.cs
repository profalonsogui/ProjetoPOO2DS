namespace SistemaBancario
{
    public class ContaBancaria
    {
        // Propriedades com Encapsulamento
        public string Titular { get; set; }
        public decimal Saldo { get; private set; } // O mundo vê, mas só a classe altera

        // Construtor: Exige o nome do titular ao criar a conta
        public ContaBancaria(string nome)
        {
            Titular = nome;
            Saldo = 0; // Começa com saldo zerado por segurança
        }

        // Métodos (Comportamentos)
        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido.");
            }
        }
    }
}