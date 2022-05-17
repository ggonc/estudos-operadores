// Exercício 9

int a, b, total;

Console.WriteLine("Informe o valor de A: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor de B: ");
b = int.Parse(Console.ReadLine());

total = a % b;

if (b == 0)
{
    Console.WriteLine("Não é possível dividir por 0.");
}
else
{
    Console.WriteLine($"A % B = {total}");
}
