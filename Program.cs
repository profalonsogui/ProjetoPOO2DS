using ProjetoPOO.ExemploPessoa;

Console.WriteLine("--- Cadastro Escolar ---");
Console.Write("Digite o Nome: ");
string nomeInput = Console.ReadLine()!;

Console.Write("Digite a Idade: ");
int idadeInput = int.Parse(Console.ReadLine()!);

Console.WriteLine("O que deseja cadastrar? [1] Aluno | [2] Professor");
string escolha = Console.ReadLine()!;

if (escolha == "1")
{
    Console.Write("Digite a Matrícula: ");
    string mat = Console.ReadLine()!;

    Aluno a = new Aluno(nomeInput, idadeInput, mat);
    a.ExibirAluno();
}
else if (escolha == "2")
{
    Console.Write("Digite a Disciplina: ");
    string disc = Console.ReadLine()!;

    Professor p = new Professor(nomeInput, idadeInput, disc);
    p.ExibirProfessor();
}