using System.Security.Cryptography;

Console.WriteLine("--- Rolagem de Dado ***");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Quantas faces? ");
int faces = Convert.ToInt32(Console.ReadLine());

int rolagem = RandomNumberGenerator.GetInt32(1, faces + 1);
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine($"Rolagem: {rolagem}");
