using System; 

public class Program {

  public static void Main(string[] args) {
    Console.Write("Resultado:");
    for (int i=1; i<=30; i++ ){
      Console.Write(" "+i);
      if (i%3==0) Console.Write($" {i + (i-1) + (i-2)}");
    }
  }
}