// Exercício 8

int a, b, total;

Console.WriteLine("Informe o valor de A: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor de B: ");
b = int.Parse(Console.ReadLine());

total = a - b;

if (total < 0)
{
    Console.WriteLine($"Total NEGATIVO pois A - B = {total}");
} else
{
    Console.WriteLine($"Total POSITIVO pois A - B = {total}");
}
