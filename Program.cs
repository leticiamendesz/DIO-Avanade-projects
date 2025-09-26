using MeuProjeto.Models;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

//Instanciando a classe Pessoa

// Pessoa p = new Pessoa("Letícia",20);
// p.Apresentar();
//--------------------------------------
//operador AND
// bool PresencaMinima = true; //Se existe mais presença do que faltas é verdadeiro se tiver mais faltas é false porque não tem presença miníma
// double Media = 6.5; //dando um valor a variável média

// if (PresencaMinima && Media >= 7) //se media for maior ou igual a 7 manda a mensagem:
// {
//     Console.WriteLine("Aprovado!");
// }

// else
// {
//     Console.WriteLine("Reprovado!");
// }

//dotnet run para rodar código

//--------------------------------------

//operadores aritméticos
// int a = 10;
// int b = 20;
// int c = b + 100;
// int s = a - b;
// Console.WriteLine("A subtração entre " + a + " e " + b + " + o valor de " + c + " é " + s);

// ou int c += 100; (operador de atribuição aditiva)
// ou int s -= b; (operador de atribuição subtrativa)
// ou int m *= 2; (operador de atribuição multiplicativa)
// ou int d /= 2; (operador de atribuição divisiva)
// ou int r %= 2; (operador de atribuição modular)
// ou int p = a + b * c; (ordem de precedência: primeiro multiplicação e divisão, depois adição e subtração)

//--------------------------------------

// //aqui é apenas a ordem a ser seguida mas o que faz funcionar é o program
// public class Calculadora //classe
// {
//     public void Somar(int x, int y) //a calculadora vai fazer a ação de somar x numero e y numero
//     {
//         Console.WriteLine($"{x} + {y} = {x + y}"); //ele vai mandar a seguinte mensagem "X numero + Y numero a soma é Z"
//     }
//     public void Subtrair(int x, int y) //a calculadora vai fazer a ação de somar x numero e y numero
//     {
//         Console.WriteLine($"{x} - {y} = {x - y}"); //ele vai mandar a seguinte mensagem "X numero + Y numero a soma é Z"
//     }
//     public void Multiplicar(int x, int y) //a calculadora vai fazer a ação de somar x numero e y numero
//     {
//         Console.WriteLine($"{x} * {y} = {x * y}"); //ele vai mandar a seguinte mensagem "X numero + Y numero a soma é Z"
//     }
//     public void Dividir(int x, int y) //a calculadora vai fazer a ação de somar x numero e y numero
//     {
//         Console.WriteLine($"{x} / {y} = {x / y}"); //ele vai mandar a seguinte mensagem "X numero + Y numero a soma é Z"
//     }

//     public void Potencia(int x, int y)
//     {
//         double pot = Math.Pow(x, y); //math.pow ele é para fazer calculos de potencia, double é porque nem sempre o resultado é inteiro, então o double consegue pegar números quebrados sem limites
//         Console.WriteLine($"{x}^{y} = {pot}");
//     }

//     public void Seno(double angulo)
//     {
//         double radiano = angulo * Math.PI / 180;
//         double Seno = Math.Sin(radiano);
//         Console.WriteLine($"Seno de {angulo} = {Math.Round(Seno, 4)}");
//     }

//     public void Coseno(double angulo)
//     {
//         double radiano = angulo * Math.PI / 180;
//         double Coseno = Math.Sin(radiano);
//         Console.WriteLine($"Coseno de {angulo} = {Math.Round(Coseno, 4)}");
//     }

//     public void Tangente(double angulo)
//     {
//         double radiano = angulo * Math.PI / 180;
//         double Tangente = Math.Tan(radiano);
//         Console.WriteLine($"Tangente de {angulo} = {Math.Round(Tangente, 4)}");
//     }

//     public void RaizQuadrada(double x)
//     {
//         double raiz = Math.Sqrt(x);
//         Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
//     }
// }

//--------------------------------------

//conversão de tipos

// int a = int.MaxValue;
// long b = a;
// Console.WriteLine(b); // saída: máx do int 2147483647

//--------------------------------------

//conversão implícita e explícita -> sem precisar da conversão e com a conversão
// int a = 5;
// double b = a; // conversão implícita de int para double
// Console.WriteLine(b); // saída: 5

//     int A = 5;
//     long b = A; // long vai ate tres vezes o int
// Console.WriteLine(b); // saída: 5
// -> n converte int para long

// long a = 5;
// int b = a; // erro de compilação: não é possível converter long para int implicitamente

// long a = 5;
// ing b = (int)a; // conversão explícita de long para int
// Console.WriteLine(b); // saída: 5

// long a = long.MaxValue;
// int b = Convert.ToInt32(a); // conversão explícita de long para int usando Convert
// Console.WriteLine(b); // saída: -1 (overflow, valor fora do intervalo do int)
//TERMINAL: Unhandled exception. System.OverflowException: Value was either too large or too small for an Int32.

//-----------------------------------------------------------------------------
// convert e parse (coverter e analisar)

// int inteiro = 9;
// string a = inteiro.ToString(); // convertendo int para string
// Console.WriteLine("O valor é " + a);

//-----------------------------------------------------------------------------
//casting (conversão de tipos) -> transformar um tipo em outro

// int a = Convert.ToInt32("10");
// int b = int.Parse("20"); saída: -1 (overflow, valor fora do intervalo do int)
// int c = a + b;
// Console.WriteLine("A soma entre " + a + " e " + b + " é " + c);


//--------------------------------------

//decisão (if, else if, else)
// int quantidadeEstoque = 9;
// int quantidadeCompra = 0;
// bool possivelRealizarCompra = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

// Console.WriteLine("Quantidade em estoque: " + quantidadeEstoque);
// Console.WriteLine("Quantidade da compra: " + quantidadeCompra);
// Console.WriteLine($"É possível realizar a compra? {possivelRealizarCompra}"); // true ou false

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida!");
// }
// else if (possivelRealizarCompra)
// {
//     Console.WriteLine("Venda realizada com sucesso!");
// }
// else //caso o if e else if sejam falsos, executa o else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque!");
// }


//--------------------------------------

//operador NOT
//NOT (!) nega as variáveis verdadeiras ou falsas
// bool choveu = true; 
// bool estaTarde = true;

// if (!choveu && !estaTarde) //Aqui ele quer negar as variaveis de choveu e estaTarde então é necessário um "!" na frente das variaveis para negar
// {
//     Console.WriteLine("Vou pedalar!!"); //Se não esta tarde e se não choveu ele vai mostrar essa mensagem
// }
// else
// {
//     Console.Write("Vou pedalar outro dia!!"); //se choveu e esta tarde ele vai mostrar essa mensagem
// }

//se choveu = false ele vai dizer que choveu porque ele vai negar o false e pôr verdadeiro, então o if não funciona
//se o estaTarde = True ele vai negar o true e colocar como falso então ele vai dizer para pedalar mais tarde

//se choveu e estaTarde for true então ele vai rodar o if, porque o if quer ele Não chovendo e Não estando tarde
//se choveu e estaTarde e for false então ele vai rodar o else porque esta chovendo e esta tarde

//--------------------------------------

//operadores lógicos

//Como usar DateTime

// DateTime dataAtual = DateTime.Now; // pega a data atual que está sendo executado no sistema
//Console.WriteLine(dataAtual);

// DateTime dataAtual = DateTime.Now.AddDays(5).AddHours(3); //Adiciona 5 dias e 3 horas na data atual
// Console.WriteLine(dataAtual);

// DateTime dataAtual = DateTime.Now.AddDays(-5).AddHours(-3); //Subtrai 5 dias e 3 horas na data atual
// Console.WriteLine(dataAtual);


//--------------------------------------

// using MeuProjeto;
//operador OR
// bool Adulto = true;
// bool Autorização = true;

// if (Adulto || Autorização) // "||" = ou. ou autorização ou adulto for verdade ele manda a mensagem
// {
//     Console.WriteLine("Entrada liberada!");
// }

// else //se não tiver autorizaçaõ ou não for adulto ele mostra essa mensagem
// {
//     Console.WriteLine("Entrada não Liberada!");
// }

//

// For calc = new For(); //calculadora = classe, calc = variavel, new calculadora = faz a classe funcionar

// internal class For
// {
// }

// calc.Somar(4, 6); //passand parâmetros. dando valores para acontecer a soma.
// calc.Subtrair(4, 6);
// calc.Multiplicar(4, 6);
// calc.Dividir(4, 6);

// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// int numero = 10;

// Console.WriteLine(numero);
// Console.WriteLine("Incrementando o 10");
// // numero = numero + 1;
// numero++; //mesma coisa que numero = numero + 1 mas mais simples
// Console.WriteLine(numero);

// int numeroSubtraido = 80;
// Console.WriteLine(numeroSubtraido);
// Console.WriteLine("Numero 80 Subtraído");
// numeroSubtraido--; //tirando -1 número do 80
// Console.WriteLine(numeroSubtraido);

//--------------------------------------

// precedência de operadores
// int a = 10 + 8 / 2;
// Console.WriteLine(a);

// int a = (10 + 8) / 2;
// Console.WriteLine(a);

// int a = 4 / (2 + 2); -> () para priorizar
// Console.WriteLine(a);

// string a = "10";
// int b = Convert.ToInt32(a); // Convertendo para int
// Console.WriteLine(b);

// string a = "10-"; -> erro de conversão. se der erro aqui, o programa para e não executa o resto
// int b = Convert.ToInt32(a) + 5; // Convertendo para int e somando 5
// Console.WriteLine(b);
//TERMINAL: Unhandled exception. System.FormatException: Input string was not in a correct format.


// string a = "10";
// int b = Convert.ToInt32(a) + 5; // Convertendo para int e somando 5
// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");

// string a = "10-";
// int b = 0;
// int.TryParse(a, out b); // tenta converter a para inteiro e armazena em b. se não conseguir, b será 0
// Console.WriteLine(b);

//--------------------------------------

//switch case
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Consoante");
// }
//-------------------------------

//como usar TimeSpan

// int quantidade = 7;
// Console.WriteLine("Valor da quantidade: " + quantidade);

// int quantidade1 = 8;
// Console.WriteLine("Valor da quantidade: " + quantidade1);

//-------------------------------

// Console.WriteLine("Digite uma letra: ");
// string entrada = Console.ReadLine().ToLower();

// // Verifica se foi digitado apenas UM caractere e se é uma letra
// // entrada.Length == 1 verifica se é 1 caractere
// //char.IsLetter verifica se é uma letra ou @,%<! etc
// // && é o "E" lógico, ou seja, as duas condições precisam ser verdadeiras, tipo um booleano
// //(entrada[0]) só aceita 1 caractere, o primeiro da string, (entrada[1]) seria o segundo caractere e assim vai

// if (entrada.Length == 1 && char.IsLetter(entrada[0]))
// {
//     if ("aeiou".Contains(entrada))
//     {
//         Console.WriteLine("Vogal");
//     }
//     else
//     {
//         Console.WriteLine("Consoante");
//     }
// }
// else
// {
//     Console.WriteLine("Entrada inválida! Digite apenas uma letra.");
// }


// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine().ToLower(); // deixa em minúsculo para evitar erro

//--------------------------------------

//Tipos de dados

// string apresentação = "Olá seja Bem-Vindo"; //string = texto

// int quantidade = 4; //int = número inteiro

// double altura = 1.80; //double = casas decimais

// float peso = 70.5f; //float = número com precisão simples

// decimal preco = 1.80m; //decimal = número com precisão maior

// bool condição = true; //bool = true ou false (verdadeiro ou falso)

// Console.WriteLine(apresentação);
// Console.WriteLine("Valor da quantidade: " + quantidade);
// Console.WriteLine("Valor da altura: " + altura.ToString("0.000")); //ToString("0.00") = para limitar o número de casas decimais
// Console.WriteLine("Valor do peso: " + peso);
// Console.WriteLine("Valor do preço: " + preco);
// Console.WriteLine("Valor da condição: " + condição);

//-------------------------------

// while (true) loop infinito
// {

// }

// int numeroSecreto = 9;
// int numeroTentativas = 0;

// Console.WriteLine("Você tem 5 tentativas para acertar o número secreto, ou se quiser sair do jogo digite 'sair'. ");

// while (numeroTentativas < 5)
// {
//     Console.WriteLine("Digite um número: ");
//     string resposta = Console.ReadLine();

//     if (resposta.ToLower() == "sair")
//     {
//         return;
//     }
// }

// if (int.TryParse(resposta, out int numero))
// {
//     numeroTentativas++;
// }

// if ()

// Console.WriteLine("Você tem 5 tentativas apara acertar o número secreto ou se quiser sair do jogo digite 'sair'.");
// Console.WriteLine(" Digite um número:");
// int resposta = Convert.ToInt32(Console.ReadLine()); //ToInt32 = converte para int e não aceita palavras etc TryParse = não aceita ".,@#%¨&*"



// if (resposta == numeroSecreto)
// {
//     Console.WriteLine("Parabéns você acertou!!" + numeroSecreto + "é o número secreto");
// }

// else if (resposta > numeroSecreto)
// {
//     Console.WriteLine("É menor que o número secreto. Tente novamente" + resposta);
// }

// else
// {
//     Console.WriteLine("É menor que o número secreto. Tente novamente" + resposta);
// }

// while (numeroTentativas >= 5)
// {
//     Console.WriteLine("Você escedeu seu limite de tentativas. Tente novamente.");
//     numeroTentativas++;
// }

//----------------------------------

// calc.RaizQuadrada(2);

// int numero = 5;
// int contador = 1;
// for (int contador = 0; contador <= 10; contador++) //para ele ir contando de 1 em 1 se usa o "variavel++"
//variavel contador começa no 0 e termina no 10 (ou 100, você escole)
// {
//     Console.WriteLine($"{numero} x {contador} é: {numero * contador}");
// }

// while (contador <= 10) // while = enquanto
// contador = começa do 0
// contador <= 10 = termina no 10
// {
//     Console.WriteLine($"{contador}ª Execução: {numero} x {contador} é: {numero * contador}");
//     contador++; //passa a quebrar o loop infinito porque ele conta de 1 em 1
// }

// int soma = 0, numero = 0; //variaveis ainda vão ser atribuidas

// do
// {
//     Console.WriteLine("digite um numero: (0 para parar o laço) "); 
//     numero = Convert.ToInt32(Console.ReadLine()); //aqui o valor vai ser atribuido pelo usuario

//     soma += numero; //quando o usuario vai escrevendo o número, os numeros vão somando

// } while (numero != 0); //quando o usuário digitar '0' a seguinte mensagem vai aparecer:

// Console.WriteLine($"Total da soma dos numeros digitados é: {soma}"); //o codigo só vai parar quando o usuário digitar 0 e depois ele mostra as somas do numeros do usuário anteriormente escrito


// string opcao; //variavel opcao do usuario
// // bool opcaoMenu = false; //se tiver false = não roda se tiver true = roda
// while (true)
// {
//     // Console.Clear(); para limpar o console enquanto o usuário escreve
//     Console.WriteLine("1 - Fazer Cadastro"); //mensagem do menu
//     Console.WriteLine("2 - Fazer Login");
//     Console.WriteLine("3 - Continuar sem Cadastro");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine(); //onde o usuario escreve o que vai escolher

//     switch (opcao)

//     {
//         case "1": //caso numero 1
//             Console.WriteLine("Fazer Cadastro");
//             break; //para na opção 1 e roda o loop novamente

//         case "2":
//             Console.WriteLine("Fazer Login");
//             break;

//         case "3":
//             Console.WriteLine("Continuar sem Cadastro");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             //opcaoMenu = false; //para encerrar tambem
//             Environment.Exit(0); //para o código no momento em que o usuário escolher numero 4, encerrar           
//             break;

//         default: //caso o usuário escreva um número não existente no menu
//             Console.WriteLine("Número inválido."); //mensagem que irá mostrar ao usuário
//             break;
//     }
// }

//--------------------------------------

// int[] arrayInteiros = new int[4];
// arrayInteiros[0] = 90;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 3;
// //Array com FOR
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

// //array com foreach
//  foreach (int valor in arrayInteiros) //para cada valor no arrayInteiros. ou seja só vai colocar o valor do array. ex: 90 e 20
//  {
//     Console.WriteLine(valor);
//  }

//para colocar o nº da posição é necessário:

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// int contadorForeach = 0;
// foreach (int valor d arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }
//--------------------------------------
//RESIZE
// int[] arrayInteiros = new int[4];
// arrayInteiros[0] = 90;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 3;

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); //mudar tamanho do array. o resize copia seus array e seus valores para o novo array. o array vai continuar com tamanho de 4 valores SEMPRE

// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }
//-------------------------------------
// int[] arrayInteiros = new int[4];
// arrayInteiros[0] = 90;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 3;


// int[] arrayInteirosCopiado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosCopiado, arrayInteiros.Length); //copia os valores do array original para preencher as linhas do novo array

// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

//fazer uma lista

List<string> ListaString = new List<string>();

ListaString.Add("SP");
ListaString.Add("MT");
ListaString.Add("PE");
ListaString.Add("RJ");




//usando FOR
// for (int contador = 0; contador < ListaString.Count; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {ListaString[contador]}");
// }

//usando FOREACH
// int contadorForeach = 0;
// foreach (string item in ListaString)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//     contadorForeach++;
// }