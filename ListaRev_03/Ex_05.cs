using System; 

public class Program {

  public static void Main(string[] args) {
    Console.Write("Resultado:");
    int n = 1;
    for (int i=1; i<=10; i++ ){
      Console.Write($" {n}");
      n += i;
    }
  }
}