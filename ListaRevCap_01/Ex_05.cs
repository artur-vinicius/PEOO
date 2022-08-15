using System; 

public class Program {
  
  public static void Main(string[] args) {
    Console.WriteLine("Digite o número de alunos:");
    int n = int.Parse(Console.ReadLine());
    int n1 = 0;
    int s = 0;
    int st = 0;
    Console.WriteLine("Digite as notas dos alunos:");
    for (int i = 1; i<=n; i++) {
      n1 = int.Parse(Console.ReadLine());
      s += n1;
      st = s / i;
    }
    Console.WriteLine($"Média das notas = {st}");
  }
}