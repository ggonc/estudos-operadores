// Exercício 1

int idadeAluno1, idadeAluno2, media;

Console.WriteLine("Informe a idade do 1º aluno: ");
idadeAluno1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a idade do 2º aluno: ");
idadeAluno2 = int.Parse(Console.ReadLine());

media = (idadeAluno1 + idadeAluno2) / 2;

Console.WriteLine($"A média de idade é de {media} anos.");
