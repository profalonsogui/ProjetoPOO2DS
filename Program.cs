using System;
using SistemaBancario; // Importa o namespace onde a classe foi criada

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BEM-VINDO AO BANCO C# ---");

        // 1. Instanciando o objeto usando o CONSTRUTOR
        // Note que passamos "João" como argumento obrigatório
        ContaBancaria contaDoJoao = new ContaBancaria("João Silva");

        // 2. Testando o Encapsulamento
        // contaDoJoao.Saldo = 5000; // <- Se descomentar isso, o C# dará ERRO de compilação!
        
        // 3. Interagindo via Métodos
        Console.WriteLine($"Titular: {contaDoJoao.Titular}");
        Console.WriteLine($"Saldo Inicial: R${contaDoJoao.Saldo}");

        contaDoJoao.Depositar(150.50m);
        contaDoJoao.Sacar(50.00m);

        // 4. Exibindo estado final
        Console.WriteLine($"Saldo Atual: R${contaDoJoao.Saldo}");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}