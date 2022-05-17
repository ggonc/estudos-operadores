// Exercício 5

int tempC, tempF;

Console.WriteLine("Informe a temperatura em ºF: ");
tempF = int.Parse(Console.ReadLine());
tempC = (tempF - 32) * 5 / 9;

Console.WriteLine($"{tempF}ºF correspondem a {tempC}ºC.");
