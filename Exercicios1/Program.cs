// See https://aka.ms/new-console-template for more information

// 1 - Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
int idade = 35;
Console.WriteLine($"Idade: {idade}");

// 2 - Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine($"Nome: {nome}");

// 3 - Crie uma variável chamada altura e atribua a ela o valor 3.45.
float altura = 3.45f;
Console.WriteLine($"Altura: {altura}");

// 4 - Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
DateTime data = new(1999, 09, 04);
Console.WriteLine($"Data: {data.ToShortDateString()}");

// 5 - Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor
const int ANO = 12;
Console.WriteLine($"Ano: {ANO}");

// 6 - Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.
double? nota = 7.80;
Console.WriteLine($"Nota: {nota}");

// 7 - Quais as diferenças entre os tipos por valor e os tipos por referência ?
// Tipos por valor em C# são armazenados diretamente na memória,
// copiados por valor e não podem ser nulos. Tipos por referência são armazenados no heap,
// copiados por referência e podem ser nulos.

// 8 - Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
// int x = 10;
// double numero = 7.99;
// char letra = 'C';
// float temperatura = 27.4f;
// bool ativo = false;
// string nome = "Manoel";
// decimal salario = 950.99m;
// DateTime hoje = DateTime.Now;

// 9 - Dada as variáveis declaradas a seguir classifique-as em tipos por valor (V) ou tipos por referência (R) :
// (V) int n = 1;
// (R) string titulo = "A vida";
// (V) float f = 12.45f;
// (V) double d = 5.45;
// (V) decimal valor = 10.99m;
// (V) char sexo = ‘M’;
// (R) object o = null;

// 10 - O que é um nullable type e qual a sua utilidade ?
// Um nullable type em C# é um tipo de dado que pode armazenar seu valor normal,
// juntamente com um valor adicional chamado "null".
// Ele permite que variáveis tenham um valor válido ou nenhum valor (null).
// Isso é útil quando você precisa representar a ausência de um valor em situações
// onde um tipo de valor não pode ser null, como int, double, bool, etc.
// O nullable type é denotado pelo sufixo '?' após o tipo (por exemplo, int?, double?, bool?).

// 11- O que é Camel Case ? Dê um exemplo de sua aplicação.
// É usado para nomear variáveis.
// string exemploDeCamelCase;

// 12- O que é Pascal Case ? Dê um exemplo de sua aplicação.
// É usado para classes e métodos.
// class ExemploDePascalCase { }

// 13 - Declare duas variáveis x e y como sendo do tipo int e atribua a ela os
// valores 77 e 66 e a seguir imprima o valor da soma de x com y.
// (Use o operador aritmético + para realizar a operação de soma)
int x = 77;
int y = 66;

int soma = x + y;
Console.WriteLine($"Soma: {soma}");

// 14 - Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
// Os valores padrão dos tipos numéricos é 0 (0, 0.0f e 0.0m).
// Do tipo booleano é false. Do tipo char é '\0' e de string é null.

// 15 - Indique verdadeiro (V) ou falso (F) para as seguintes declarações de variáveis
// considerando a nomenclatura usada:
// (F) double 1valor = 12.45;
// (F) string #nome = "Pedro";
// (V) float _temperatura = 12.45f;
// (F) double int = 5;
// (F) decimal renda extra = 91.45m;
// (F) bool status$conta = false;
// (V) string titulo3 = “Tópico 1”;
// (V) float salario_mensal = 1999.55f;
// (V) int percentualValorDesconto = 5;
// (V) const bool MENSALIDADE_EM_DIA = true;

Console.ReadKey();
