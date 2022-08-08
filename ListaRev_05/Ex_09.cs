using System; 

public class Program {
  public static int Soma(int inicio, int fim) {
    int soma = 0;
    for (int i = inicio; i<=fim; i++) {
      soma += i; }
    return soma;
    }
  public static void Main(string[] args) {
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine(Soma(n1,n2));
  }
}
