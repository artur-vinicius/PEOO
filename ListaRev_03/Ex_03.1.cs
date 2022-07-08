using System; 

public class Program {

  public static void Main(string[] args) {
    Console.Write("Resultado:");
    for (int i=1; i<=10; i++ ){
      if (i%2==0) Console.Write($" -{i}");
      else Console.Write(" "+i);
    }
  }
}