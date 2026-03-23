using System;
using SistemaBancario;

class Program
{
    static void Main(string[] args)
    {
        // 1. Primeiro criamos o objeto "independente" (O Titular)
        Titular pessoa = new Titular("Carlos Oliveira", "123.456.789-00");

        // 2. Agora criamos a Conta e PASSAMOS o objeto 'pessoa' para dentro dela
        // Isso é a associação de objetos!
        ContaBancaria minhaConta = new ContaBancaria(pessoa);

        minhaConta.Depositar(500);
        
        // 3. Exibindo os dados integrados
        minhaConta.ExibirResumo();

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}