namespace ProjetoPOO.ExemploPessoa
{
    public class Professor : Pessoa // Herança
    {
        public string Disciplina { get; private set; }

        public Professor(string nome, int idade, string disciplina) : base(nome, idade)
        {
            Disciplina = disciplina;
        }

        public void ExibirProfessor()
        {
            Console.WriteLine($"[PROFESSOR] Nome: {_nome} | Disciplina: {Disciplina}");
        }
    }
}