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


