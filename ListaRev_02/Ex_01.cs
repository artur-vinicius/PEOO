using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite um Valor Inteiro:");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um Outro Valor Inteiro:");
    int n2 = int.Parse(Console.ReadLine());
    if (n1>n2) Console.WriteLine($"Maior = {n1}");
    else if (n2>n1) Console.WriteLine($"Maior = {n2}");
    else Console.WriteLine("Números Iguais");
  }
}