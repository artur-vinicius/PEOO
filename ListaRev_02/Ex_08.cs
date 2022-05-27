using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite quatro valores inteiros:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int menor = a;
    int maior = d;
    if (a!=b || a!=c || a!=d) {
      if (b<menor) menor = b;
      if (c<menor) menor = c;
      if (d<menor) menor = d;
      if (a>maior) maior = a;
      if (b>maior) maior = b;
      if (c>maior) maior = c;
      Console.WriteLine($"Maior valor = {maior}");
      Console.WriteLine($"Menor valor = {menor}");
      Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {maior+menor}");
    }
    else Console.WriteLine("[Error] valores iguais");
  }
}