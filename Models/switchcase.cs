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