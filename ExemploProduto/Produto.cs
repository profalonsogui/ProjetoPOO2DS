namespace ExemploProduto
{
    public class Produto
    {
        public string Nome { get; }
        public double PrecoBase { get; }
        public Marca Fabricante { get; }

        public Produto(string nome, double precoBase, Marca fabricante)
        {
            Nome = nome;
            PrecoBase = precoBase;
            Fabricante = fabricante;
        }

        public double CalcularPrecoFinal()
        {
            // Lógica: Preço - (Preço * Desconto da Marca)
            return PrecoBase - (PrecoBase * Fabricante.DescontoOferecido);
        }

        public void ExibirCupom()
        {
            Console.WriteLine($"--- Cupom Fiscal ---");
            Console.WriteLine($"Item: {Nome} | Marca: {Fabricante.Nome}");
            Console.WriteLine($"Preço Original: R${PrecoBase:F2}");
            Console.WriteLine($"Desconto da Marca: {Fabricante.DescontoOferecido * 100}%");
            Console.WriteLine($"TOTAL A PAGAR: R${CalcularPrecoFinal():F2}");
            Console.WriteLine("--------------------\n");
        }
    }
}