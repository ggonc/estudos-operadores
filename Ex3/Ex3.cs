// Exercício 3

double totalVenda, taxaComissao, valorComissao;

Console.WriteLine("Informe o valor vendido no mês pelo funcionário: ");
totalVenda = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a taxa de comissão do funcionário (em decimais): ");
taxaComissao = double.Parse(Console.ReadLine());

valorComissao = totalVenda * taxaComissao;
Console.WriteLine($"A comissão recebida pelo funcionário será de R$ {valorComissao}.");
