using System; 

public class Program {

  public static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int n1 = 0;
    int n2 = 1;
    if (n==1) Console.WriteLine("0");
    else if (n>1) {
      Console.Write("0 1");
      for (int i = 1; i<n-1; i++){
        int fib = n1 + n2;
        Console.Write(" " + fib);
        n1 = n2;
        n2 = fib;
      }
      Console.WriteLine();
    }
  }
}