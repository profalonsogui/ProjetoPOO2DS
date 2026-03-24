namespace SistemaBancario
{
    public class ContaBancaria
    {
        public decimal Saldo { get; private set; }
        
        // ASSOCIAÇÃO: A conta "tem um" Titular
        public Titular Dono { get; private set; }

        // Construtor: Recebe o objeto Titular pronto
        public ContaBancaria(Titular cliente)
        {
            Dono = cliente;
            Saldo = 0;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0) Saldo += valor;
        }

        public void ExibirResumo()
        {
            // Note como acessamos o nome que está DENTRO do objeto Dono
            Console.WriteLine($"Conta de: {Dono.Nome} | CPF: {Dono.CPF} | Saldo: R${Saldo}");
        }
    }
}