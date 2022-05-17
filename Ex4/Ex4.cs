// Exercício 4

int tempC, tempF;

Console.WriteLine("Informe a temperatura em ºC: ");
tempC = int.Parse(Console.ReadLine());
tempF = ((9 * tempC) + 160) / 5;

Console.WriteLine($"{tempC}ºC correspondem a {tempF}ºF.");
