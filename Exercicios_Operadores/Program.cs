// Exercício 1
/*
int idadeAluno1, idadeAluno2, media;

idadeAluno1 = 20;
idadeAluno2 = 50;

media = (idadeAluno1 + idadeAluno2) / 2;

Console.WriteLine($"A média de idade é de {media} anos.");
*/

//==============================================================

// Exercício 2
/*
double cotEuro, euro, real;

Console.WriteLine("Informe a cotação atual do Euro: ");
cotEuro = Double.Parse(Console.ReadLine());

euro = 750;
real = cotEuro * euro;

Console.WriteLine($"O valor de ${euro} euros corresponde a R${real}.");
*/

//==============================================================

// Exercício 3
/*
double totalVenda, taxaComissao, valorComissao;

totalVenda = 500000;
taxaComissao = 0.05;

valorComissao = totalVenda * taxaComissao;
Console.WriteLine($"A comissão recebida pelo funcionário será de R$ {valorComissao}.");
*/

//==============================================================

// Exercício 4
/*
int tempC, tempF;

Console.WriteLine("Informe a temperatura em ºC: ");
tempC = int.Parse(Console.ReadLine());
tempF = ((9 * tempC) + 160) / 5;

Console.WriteLine($"{tempC}ºC correspondem a {tempF}ºF.");
*/

//==============================================================

// Exercício 5
/*
int tempC, tempF;

Console.WriteLine("Informe a temperatura em ºF: ");
tempF = int.Parse(Console.ReadLine());
tempC = (tempF - 32) * 5 / 9;

Console.WriteLine($"{tempF}ºF correspondem a {tempC}ºC.");
*/

//==============================================================

// Exercício 6
/*
double altura, pesoIdeal;

Console.WriteLine("Informe a altura em metros: ");
altura = double.Parse(Console.ReadLine());

pesoIdeal = Math.Round(((72.7 * altura) - 58), 3);

Console.WriteLine($"Para uma altura de {altura}m, o peso ideal seria de {pesoIdeal}Kg");
*/

//==============================================================

// Exercício 7
/*
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
*/

//==============================================================

// Exercício 8
/*
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
*/

//==============================================================

// Exercício 9
/*
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
*/

//==============================================================

// Exercício 10

// Ex1)
/*
int idadeAluno1, idadeAluno2, media;

Console.WriteLine("Informe a idade do 1º aluno: ");
idadeAluno1 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe a idade do 2º aluno: ");
idadeAluno2 = int.Parse(Console.ReadLine());

media = (idadeAluno1 + idadeAluno2) / 2;

Console.WriteLine($"A média de idade é de {media} anos.");
*/

// Ex2)
/*
double cotEuro, euro, real;

Console.WriteLine("Informe a cotação atual do Euro: ");
cotEuro = Double.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor em Euros que deseja converter em Reais: ");
euro = double.Parse(Console.ReadLine());

real = cotEuro * euro;

Console.WriteLine($"O valor de $ {euro} euros corresponde a R$ {real}.");
*/

// Ex3)
/*
double totalVenda, taxaComissao, valorComissao;

Console.WriteLine("Informe o valor vendido no mês pelo funcionário: ");
totalVenda = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a taxa de comissão do funcionário (em decimais): ");
taxaComissao = double.Parse(Console.ReadLine());

valorComissao = totalVenda * taxaComissao;
Console.WriteLine($"A comissão recebida pelo funcionário será de R$ {valorComissao}.");
*/

// Ex4)
/*
int tempC, tempF;

Console.WriteLine("Informe a temperatura em ºC: ");
tempC = int.Parse(Console.ReadLine());
tempF = ((9 * tempC) + 160) / 5;

Console.WriteLine($"{tempC}ºC correspondem a {tempF}ºF.");
*/

// Ex5)
/*
int tempC, tempF;

Console.WriteLine("Informe a temperatura em ºF: ");
tempF = int.Parse(Console.ReadLine());
tempC = (tempF - 32) * 5 / 9;

Console.WriteLine($"{tempF}ºF correspondem a {tempC}ºC.");
*/

// Ex6)
/*
double altura, pesoIdeal;

Console.WriteLine("Informe a altura em metros: ");
altura = double.Parse(Console.ReadLine());

pesoIdeal = Math.Round(((72.7 * altura) - 58), 3);

Console.WriteLine($"Para uma altura de {altura}m, o peso ideal seria de {pesoIdeal}Kg");
*/

// Ex7)
/*
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
}
else
{
    Console.WriteLine($"O aluno foi REPROVADO com média igual a {media}!");
}
*/

// Ex8)
/*
int a, b, total;

Console.WriteLine("Informe o valor de A: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor de B: ");
b = int.Parse(Console.ReadLine());

total = a - b;

if (total < 0)
{
    Console.WriteLine($"Total NEGATIVO pois A - B = {total}");
}
else
{
    Console.WriteLine($"Total POSITIVO pois A - B = {total}");
}
*/

// Ex9)
/*
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
*/

//==============================================================