namespace SistemaBancario
{
    public class Titular
    {
        // Encapsulamento: Nome e CPF só podem ser lidos por fora
        public string Nome { get; private set; }
        public string CPF { get; private set; }

        // Construtor: Obriga a ter os dados do dono ao criar o objeto
        public Titular(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
    }
}