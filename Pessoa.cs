class Pessoa
{
    // atributos
    public string? Nome;
    public int Idade;

    // métodos
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}