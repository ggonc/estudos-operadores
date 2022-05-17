// Exercício 6

double altura, pesoIdeal;

Console.WriteLine("Informe a altura em metros: ");
altura = double.Parse(Console.ReadLine());

pesoIdeal = Math.Round(((72.7 * altura) - 58), 3);

Console.WriteLine($"Para uma altura de {altura}m, o peso ideal seria de {pesoIdeal}Kg");
