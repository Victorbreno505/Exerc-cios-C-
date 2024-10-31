/*
//Exercício 16 [Desafio]

Console.WriteLine("========================================");
Console.WriteLine("              Dias Perdidos             ");
Console.WriteLine("========================================");

Console.Write("Quantos cigarros são consumidos por dia: ");
int cigarro = int.Parse(Console.ReadLine());
Console.Write("Há Quantos anos você fuma?: ");
int anos = int.Parse(Console.ReadLine());

int quantidade = anos * 365 * cigarro;
int minutos = quantidade * 10;
int diasPerdidos = minutos / 1440;
Console.WriteLine("========================================");
Console.WriteLine($"O total de dias perdidos de vida {diasPerdidos:F2}\n"
                    + $"Cigarros Fumados = {quantidade}\n"
                    + $"Anos = {anos}");
Console.WriteLine("========================================");
                
//Exercício 15
Console.WriteLine("========================================")
console.WriteLine("             Calculo Salário            ")
Console.WriteLine("========================================")

Console.Write("Total de dias trabalhados: ");
int dias = int.Parse(Console.ReadLine());

int horasDia = 8;

double total = dias * horasDia * 25;

Console.WriteLine($"O salário recebido em um total de {dias} dias trabalhados é de :{total}");


//Exercicio 14

Console.WriteLine("===================================");
Console.WriteLine("         Locadora AutoBanh         ");
Console.WriteLine("===================================");

Console.Write("Qual a Quantidade de Quilometros(Km) percorridos: ");
double km = double.Parse(Console.ReadLine());
Console.Write("Qual a quantidade de Dias que o veículo foi alugado: ");
int dias = int.Parse(Console.ReadLine());

double valorDia = 90;
double valorKm = 0.20;

double valorFinal = (dias * valorDia) + km * valorKm;

Console.WriteLine("===================================");
Console.WriteLine($"O valor final do aluguel do veiculo é: \n"
                + $"Quilometros  \t  =\t {km} Km\n" 
                + $"Dias Alugados \t  =\t {dias} Dias\n"
                + $"Valor Fixo Diária = \t {valorDia} R$");

Console.WriteLine("===================================");
Console.WriteLine($"Valor final = {valorFinal}.");
Console.WriteLine("===================================");

//Exercicio 13

Console.WriteLine("===============================================");
Console.WriteLine("                 Aumento Salário               ");
Console.WriteLine("===============================================");
Console.Write("Qual o Salário do Funcionário: ");
double salario = double.Parse(Console.ReadLine());

double porcentagem = (salario / 100) * 15;
double salarioAtualizado = salario + porcentagem;

Console.WriteLine($"O salário atualizado ddo Funcionário foi de {salario} para {salarioAtualizado} totalizando um aumento de {porcentagem} (15%).");
Console.WriteLine("===============================================");

//Exercício 12

Console.WriteLine("======================================");
Console.WriteLine("           Preço Promocional          ");
Console.WriteLine("======================================");

Console.Write("Qual o preço do Produto: ");
double preço = double.Parse(Console.ReadLine());

double valorP = (preço / 100) * 5;

Console.WriteLine($"O valor do Produto com o Desconto aplicado é de: {valorP}" + " R$");

//Exercício 11

    Console.Write("Digite o valor de A: ");
double valorA = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor de B: ");
double valorB = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor de C: ");
double valorC = double.Parse(Console.ReadLine());
// Math.Pow = elevado
double delta = Math.Pow(valorB, 2) - 4 * valorA * valorC;

Console.WriteLine($"O valor de Delta Δ é {delta}");


//Exercício 10

Console.WriteLine("========================================");
Console.WriteLine("                Tinta/Metro²            ");
Console.WriteLine("========================================");

Console.Write("Digite a Largura da parede: ");
int largura = int.Parse(Console.ReadLine());

Console.Write("Digite a Altura da parede: ");
int altura = int.Parse(Console.ReadLine());
//formula - area = largura * altura / N

//Metros Quadrados por Litros de Tinta
int tinta = 2;

int area = (largura * altura) / tinta;
Console.WriteLine("========================================");
Console.WriteLine($"A Quantidade de Tinta em litros para o serviço é de :{area}");
Console.WriteLine("========================================");

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