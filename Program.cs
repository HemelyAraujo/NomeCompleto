// See https://aka.ms/new-console-template for more information
string nome, sobrenome;
Console.WriteLine("Digite seu nome");
nome = Console.ReadLine()!;

Console.Write("Digite seu sobrenome");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"nome completo: {nome} {sobrenome}");
Console.WriteLine($"nome de catalogo: {sobrenome.ToUpper()}, {nome}");
