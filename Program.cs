using System.Collections.Generic;
using ExemploProduto;

// 1. Criamos um catálogo de marcas disponíveis
List<Marca> catalogoMarcas = new List<Marca>
{
    new Marca("Geral", 0.0),      // Sem desconto
    new Marca("Samsung", 0.05),   // 5% de desconto
    new Marca("Apple", 0.02),     // 2% de desconto
    new Marca("Xiaomi", 0.15)     // 15% de desconto (Bom desconto!)
};

// 2. Interação com o usuário
Console.Write("Digite o nome do produto: ");
string nomeProd = Console.ReadLine()!;

Console.Write("Digite o preço base: ");
double precoProd = double.Parse(Console.ReadLine()!);

Console.WriteLine("\nEscolha a Marca pelo número:");
for (int i = 0; i < catalogoMarcas.Count; i++)
{
    Console.WriteLine($"{i} - {catalogoMarcas[i].Nome}");
}

int opcao = int.Parse(Console.ReadLine()!);

// 3. Criar o produto com a marca escolhida da lista
Marca marcaEscolhida = catalogoMarcas[opcao];
Produto novoProduto = new Produto(nomeProd, precoProd, marcaEscolhida);

// 4. Resultado
Console.Clear();
novoProduto.ExibirCupom();