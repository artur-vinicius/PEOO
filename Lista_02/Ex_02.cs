using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite Seu Nome Completo:");
    string[] nome = Console.ReadLine().Split(' ');
    Console.WriteLine($"Bem-vindo ao C#, {nome[0]}");
  }
}
