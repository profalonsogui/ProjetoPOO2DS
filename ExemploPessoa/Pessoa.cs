namespace ProjetoPOO.ExemploPessoa
{
    public class Pessoa
    {
        // Protected: Agora os "filhos" (Aluno/Professor) podem acessar
        protected string _nome;
        protected int _idade;

        public string Nome => _nome;
        public int Idade => _idade;

        // Construtor do Pai
        public Pessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        public virtual void Apresentar() // 'virtual' permite que o filho personalize a apresentação
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {_idade}");
        }
    }
}