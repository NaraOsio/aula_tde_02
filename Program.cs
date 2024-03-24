//Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno tem anos e nota usando a concatenação e a interpolação de strings.
// Declaração das variáveis
using System.Runtime.CompilerServices;

string nome = "Paulo";
int idade = 17;
double nota = 7.5;

string concatenacao = "Aluno " + nome + " tem " + idade + " anos e nota " + nota + ".";
string interpolacao = $"Aluno {nome} tem {idade} anos e nota {nota}.";

Console.WriteLine(concatenacao);
Console.WriteLine(interpolacao);


//Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
//escapes.
Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nNota: {nota}");


// Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// (x) double
// ( ) long
// ( ) decimal 
//float valor = 10.0F;
//int valorInt = valor;
//double valorDouble = valor;
//long valorLong = valor;
//decimal valorDecimal = valor;



//Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// ( ) int para long
// (x) double para long
// (x) double para float
// (x) decimal para float
// (x) long para int
// (x) double para decimal
//int valorInt = 10;
//long valorLong = valorInt;
//double valorDouble = 10.0;
//long valorLong = valorDouble;
//double valorDouble = 10.0;
//float valorFloat = valorDouble;
//decimal valorDecimal = 10.0M;
//float valorFloat = valorDecimal;
//long valorLong = 10;
//int valorInt = valorLong;
//double valorDouble = 10.0D;
//decimal valorDecimal = valorDouble;




//Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
//a concatenação e também a interpolação de strings
Console.WriteLine("Digite a primeira letra");
var letra1 = Console.ReadLine();

Console.WriteLine("Digite a segunda letra");
var letra2 = Console.ReadLine();

Console.WriteLine("Digite a terceira letra");
var letra3 = Console.ReadLine();

Console.WriteLine(letra3 + " " + letra2 + " " + letra1);
Console.WriteLine($"{letra3} {letra2} {letra1}");




// Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (V) var nome = “Maria”;
// (V) string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (F) float f = 5.45; o correto seria float f = 5.45F;
// (V) decimal valor = (decimal) 10.99f;
// (F) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (V) A sequencia \t inclui uma tabulação vertical




// Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:


Console.Write("Digite o primeiro valor: ");
double valor1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
double valor2 = double.Parse(Console.ReadLine());

double resultadoSoma = valor1 + valor2;
double resultadoSubtracao = valor1 - valor2;
double resultadoMultiplicacao = valor1 * valor2;
double resultadoExponenciacao = Math.Pow(valor1, valor2);
double resultadoDivisao = valor1 / valor2;
double resultadoModulo = valor1 % valor2;

Console.WriteLine(resultadoSoma);
Console.WriteLine(resultadoSubtracao);
Console.WriteLine(resultadoMultiplicacao);
Console.WriteLine(resultadoExponenciacao);
Console.WriteLine(resultadoDivisao);
Console.WriteLine(resultadoModulo);


// Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
// inválido’: (use o operador condicional ternário)

Console.WriteLine("Digite o nome");
string loginNome = Console.ReadLine();

Console.WriteLine("Digite a senha");
int loginSenha = int.Parse(Console.ReadLine());

string resultado = ((loginNome == "admin" || loginNome == "maria") && loginSenha == 123) ? "Login feito com sucesso" : "Login invalido";
Console.WriteLine(resultado);




// Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
// console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
Console.WriteLine("Digite o primeiro valor");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor");
int y = int.Parse(Console.ReadLine());

Console.WriteLine(x % 2 == 0 ? "Par" : "Impar");
Console.WriteLine(y % 2 == 0 ? "Par" : "Impar");