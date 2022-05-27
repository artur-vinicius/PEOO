using System; 

public class Program {

  public static void Main(string[] args) {
    int[] num = new int[4];
    int par = 0;
    int imp = 0;
    Console.WriteLine("Digite Quatro Valores Inteiros:");
    for (int i=0; i<4; i++) {
      num[i] = int.Parse(Console.ReadLine());
    }
    foreach (int c in num) {
      if (c%2==0) {
        par += c;
      }
      else {
        imp += c;
      }
    }
    Console.WriteLine($"A soma dos pares = {par}");
    Console.WriteLine($"A soma dos ímpares = {imp}");
  }
}