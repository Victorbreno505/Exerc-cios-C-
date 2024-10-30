




/*
//Exercício 9

Console.WriteLine("======================================");
Console.WriteLine("         Conversão Real/Dolar         ");
Console.WriteLine("======================================");

Console.Write("Quantos (R$) você possui na sua carteira: ");
decimal carteira = decimal.Parse(Console.ReadLine());
Console.Write("Qual o valor atual do Dólar: ");
decimal dolar = decimal.Parse(Console.ReadLine());

decimal conversão = carteira / dolar;
Console.WriteLine("======================================");
Console.WriteLine($"A conversão de {carteira:F2} (R$) com o dólar em {dolar:F2} ($) é de {conversão:F2}($).");
Console.WriteLine("======================================");

//Exercicio 8

Console.WriteLine("=============================================");
Console.WriteLine("        Leitor de Distâncias em Metros        ");
Console.WriteLine("=============================================");

Console.Write("Digite uma Distância em Metros: ");
decimal metros = decimal.Parse(Console.ReadLine());
Console.WriteLine($"A Distância  de {metros:F2} corresponde a: ");

decimal km = metros / 1000;
decimal hm = metros / 100;
decimal dam = metros / 10;
decimal dm = metros * 10;
decimal cm = metros * 100;
decimal mm = metros * 1000;

Console.WriteLine($"{km:F5}Km\t\t\t{dm:F1}Dm\n{hm:F4}Hm\t\t\t{cm:F1}Cm\n{dam:F3}Dam\t\t\t{mm:F1}Mm");
Console.WriteLine("=============================================");

//Exercício 7

Console.Write("Digite um Número: ");
decimal numero = decimal.Parse(Console.ReadLine());

decimal dobro = numero * 2;
decimal terça = numero / 3;

Console.WriteLine($"O Dobro de {numero:F2} é {dobro:F2}.");
Console.WriteLine($"A terça parte de {numero:F2} é {terça:F2}.");

//Exercício 6

Console.WriteLine("=========================");
Console.WriteLine("  Sucessor e Antecessor  ");
Console.WriteLine("=========================");

Console.Write("Digite um Número: ");
int valor = int.Parse(Console.ReadLine());

int antecessor = valor - 1;
int sucessor = valor + 1;

Console.WriteLine($"O Antecessor de {valor} é {antecessor}");
Console.WriteLine($"O Sucessor de {valor} é {sucessor}");
Console.WriteLine("=========================");


//Exercício 5

Console.WriteLine("=========================");
Console.WriteLine("          Médias         ");
Console.WriteLine("=========================");

Console.Write("Qual o Nome do Aluno: ");
string nomeAluno = Console.ReadLine();

Console.Write("Nota 1: ");
double notaUm = double.Parse(Console.ReadLine());

Console.Write("Nota 2: ");
double notaDois = double.Parse(Console.ReadLine());
//Fórmula Média - N1 + N2 / 2 (Quantidade de N).

Console.Clear();

double media = (notaUm + notaDois) / 2;
Console.WriteLine("======================================================");
Console.WriteLine($"A média entre {notaUm:f1} e {notaDois:f1} é igual a {media}");
Console.WriteLine("======================================================");


Exercício 4

Console.Write("Digite um Valor: ");
//Conversão do valor para int, já que manipularemos um número.
int valorUm = int.Parse(Console.ReadLine());

Console.Clear();

Console.Write("Digite outro Valor: ");
int valorDois = int.Parse(Console.ReadLine());

Console.Clear();

Console.Write($"A soma entre {valorUm} e {valorDois} é igual a {valorUm + valorDois}");


Exercicio 3

Console.Write("Nome do Funcionário: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe o Salário: ");//Resultado será uma string

//Não Convertido pega o valor em string e exibe.

//string salario = Console.ReadLine();

//Convertido por meio de Parse.

//Diretamente convertemos o valor, declarando seu tipo = tipo.parse(do valor inserido no Console read.)
double salario = double.Parse(Console.ReadLine());
//{salario:F2}: Aqui, F2 indica que o valor será exibido com 2 casas decimais
Console.WriteLine($"O Funcionário {nome} tem um salário de R${salario:F2} em junho");


Exercício 2 - Solicitando um nome e mostrando mensagem de boas Vindas.

Console.Write("Qual é o seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name}, é um prazer te conhecer!");

Exercício 1 - Escreva um programa que mostre na tela a mensagem "Olá, Mundo!"

Console.WriteLine("Olá Mundo!");
*/