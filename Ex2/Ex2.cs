// Exercício 2

double cotEuro, euro, real;

Console.WriteLine("Informe a cotação atual do Euro: ");
cotEuro = Double.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor em Euros que deseja converter em Reais: ");
euro = double.Parse(Console.ReadLine());

real = cotEuro * euro;

Console.WriteLine($"O valor de $ {euro} euros corresponde a R$ {real}.");

