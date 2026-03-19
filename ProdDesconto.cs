class ProdDesconto
{
    public string? Nome;
    public double Preco;

    public double AplicarDesconto(double percentual)
    {
        return Preco - (Preco * percentual / 100);
    }
}