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
