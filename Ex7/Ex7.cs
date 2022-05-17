// Exercício 7

double nota1, nota2, nota3, nota4, media;

Console.WriteLine("Informe a 1ª nota: ");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a 2ª nota: ");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a 3ª nota: ");
nota3 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a 4ª nota: ");
nota4 = double.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

if (media >= 7) 
{
    Console.WriteLine($"O aluno foi APROVADO com média igual a {media}!");
} else 
{
    Console.WriteLine($"O aluno foi REPROVADO com média igual a {media}!");
}
