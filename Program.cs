using System;
using System.Text;


class Program
{
    static void Main()
    {
        Pessoa p1 = new Pessoa();
        Produto prod1 = new Produto();

        //p1.Nome = "josé";
        //p1.Idade = 27;

        prod1.Nome = "Notebook Acer Nitro v15";
        prod1.Preco = 7999.99;

        Console.Write("Digite o nome: ");
        p1.Nome = Console.ReadLine()!;

        Console.Write("Digite a idade: ");
        p1.Idade = int.Parse(Console.ReadLine()!);

        p1.Apresentar();
        Console.WriteLine($"Nome produto: {prod1.Nome}");
        Console.WriteLine($"Preço produto: {prod1.Preco}");

        Console.WriteLine($"O cliente {p1.Nome} comprou o produto: {prod1.Nome} e pagou R${prod1.Preco}.");
    }
}