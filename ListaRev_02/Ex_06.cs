using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite Três Valores Inteiros:");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int n3 = int.Parse(Console.ReadLine());
    if (n1>=n2 && n1>=n3) {
      if (n2<=n3) Console.WriteLine($"A soma do maior com o menor número é {n1+n2}.");
      else Console.WriteLine($"A soma do maior com o menor número é {n1+n3}.");
    }
    else if (n2>=n1&& n2>=n3) {
      if (n1<=n3) Console.WriteLine($"A soma do maior com o menor número é {n2+n1}.");
      else Console.WriteLine($"A soma do maior com o menor número é {n2+n3}.");
    }
    else {
      if (n1<=n2) Console.WriteLine($"A soma do maior com o menor número é {n3+n1}.");
      else Console.WriteLine($"A soma do maior com o menor número é {n3+n2}.");
    }
  }
}