using System;

namespace ExemploProduto
{
    // A classe ProdDesconto herda de Produto
    public class ProdDesconto : Produto
    {
        public double Porcentagem { get; }

        // O construtor precisa receber os dados e repassar para o 'base' (Produto)
        public ProdDesconto(string nome, double precoBase, Marca fabricante, double porcentagem)
            : base(nome, precoBase, fabricante)
        {
            Porcentagem = porcentagem;
        }

        public void ExibirComDesconto()
        {
            // CORREÇÃO: Usando 'PrecoBase' e 'Nome' que existem na classe Produto
            double valorFinal = PrecoBase - (PrecoBase * Porcentagem / 100);

            Console.WriteLine($"[PROMOÇÃO EXTRA] {Nome}");
            Console.WriteLine($"De: R${PrecoBase:F2} por apenas R${valorFinal:F2}!");
            Console.WriteLine($"Desconto aplicado: {Porcentagem}%");
            Console.WriteLine("--------------------\n");
        }
    }
}