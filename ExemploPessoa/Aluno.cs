namespace ProjetoPOO.ExemploPessoa
{
    public class Aluno : Pessoa // Herança
    {
        public string Matricula { get; private set; }

        // O construtor do Aluno recebe o que o Pai precisa e o que ele mesmo precisa
        public Aluno(string nome, int idade, string matricula) : base(nome, idade)
        {
            Matricula = matricula;
        }

        public void ExibirAluno()
        {
            // Note que acessamos o _nome que veio da classe Pessoa
            Console.WriteLine($"[ALUNO] Nome: {_nome} | Matrícula: {Matricula}");
        }
    }
}