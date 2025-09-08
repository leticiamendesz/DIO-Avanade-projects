using System;

int quantidadeEstoque = 0;
int quantidadeCompra = 10;
bool possivelRealizarCompra = quantidadeEstoque >= quantidadeCompra;

Console.WriteLine("Quantidade em estoque: " + quantidadeEstoque);
Console.WriteLine("Quantidade da compra: " + quantidadeCompra);
Console.WriteLine($"É possível realizar a compra? {possivelRealizarCompra}"); // true ou false

if (quantidadeCompra <= 0)
{
    Console.WriteLine("Quantidade de compra inválida!");
}
else if (possivelRealizarCompra)
{
    Console.WriteLine("Venda válida!");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque!");
}

//--------------------------------------------------------------------------------
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



//--------------------------------------------------------------------------------
//conversão de tipos

// int a = int.MaxValue;
// long b = a;
// Console.WriteLine(b); // saída: máx do int 2147483647

//--------------------------------------------------------------------------------
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
// convert e parse

// int inteiro = 9;
// string a = inteiro.ToString(); // convertendo int para string
// Console.WriteLine("O valor é " + a);

//-----------------------------------------------------------------------------
//casting (conversão de tipos) -> transformar um tipo em outro

// int a = Convert.ToInt32("10");
// int b = int.Parse("20"); saída: -1 (overflow, valor fora do intervalo do int)
// int c = a + b;
// Console.WriteLine("A soma entre " + a + " e " + b + " é " + c);

//-----------------------------------------------------------------------------

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


//--------------------------------------------------------------------------------

//operadores lógicos

//Como usar DateTime

// DateTime dataAtual = DateTime.Now; // pega a data atual que está sendo executado no sistema
//Console.WriteLine(dataAtual);

// DateTime dataAtual = DateTime.Now.AddDays(5).AddHours(3); //Adiciona 5 dias e 3 horas na data atual
// Console.WriteLine(dataAtual);

// DateTime dataAtual = DateTime.Now.AddDays(-5).AddHours(-3); //Subtrai 5 dias e 3 horas na data atual
// Console.WriteLine(dataAtual);

//--------------------------------------------------------------------------------

//como usar TimeSpan

// int quantidade = 7;
// Console.WriteLine("Valor da quantidade: " + quantidade);

// int quantidade1 = 8;
// Console.WriteLine("Valor da quantidade: " + quantidade1);

//--------------------------------------------------------------------------------

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

//--------------------------------------------------------------------------------

//Instanciando a classe Pessoa

    // Pessoa p = new Pessoa("Letícia", 20);
    // p.Apresentar();