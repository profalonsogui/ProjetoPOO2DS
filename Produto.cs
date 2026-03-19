class Produto
{
    public string? Nome;
    public double Preco;

    public void mostrarProduto()
    {
        Console.WriteLine($"O produto é: {Nome} e seu preço é: {Preco}");
    }
}