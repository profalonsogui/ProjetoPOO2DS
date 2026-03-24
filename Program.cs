using SistemaBancario;

Console.WriteLine("=== SISTEMA BANCÁRIO POO ===");

// Passo 1: Criar o Titular (Comum a todos)
Console.Write("Nome do Titular: ");
string nome = Console.ReadLine()!;
Console.Write("CPF do Titular: ");
string cpf = Console.ReadLine()!;

Titular t1 = new Titular(nome, cpf);

// Passo 2: Escolher o tipo de conta
Console.WriteLine("\nEscolha o tipo de conta: [1] Poupança | [2] Corrente");
string opcao = Console.ReadLine()!;

if (opcao == "1")
{
    ContaPoupanca cp = new ContaPoupanca(t1);
    cp.Depositar(500); // Método que veio do pai
    cp.RenderJuros();  // Método exclusivo da Poupanca
    Console.WriteLine($"Saldo Poupança: R$ {cp.Saldo}");
}
else if (opcao == "2")
{
    Console.Write("Qual o valor do limite de crédito? ");
    decimal limiteDigitado = decimal.Parse(Console.ReadLine()!);

    // Criando a ContaCorrente com o limite digitado
    ContaCorrente cc = new ContaCorrente(t1, limiteDigitado);
    cc.Depositar(1000);
    cc.ExibirDadosCorrente(); // Método exclusivo da Corrente
}
else
{
    Console.WriteLine("Opção inválida!");
}