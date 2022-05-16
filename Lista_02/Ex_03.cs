using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    int nota1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    int nota2 = int.Parse(Console.ReadLine());
    int p1 = 2;
    int p2 = 3;
    int med = ((p1 * nota1) + (p2 * nota2)) / (p1 + p2);
    Console.WriteLine($"Média Parcial = {med}");
  }
}
