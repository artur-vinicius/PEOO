using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite três Valores:");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    if (a>=b && a>=c) {
      if (b>=c) Console.WriteLine($"{c}, {b}, {a}");
      else Console.WriteLine($"{b}, {c}, {a}");
    } 
    else if (b>=a && b>=c) {
      if (a>=c) Console.WriteLine($"{c}, {a}, {b}");
      else Console.WriteLine($"{a}, {c}, {b}");
    }
    else {
      if (a>=b) Console.WriteLine($"{b}, {a}, {c}");
      else Console.WriteLine($"{a}, {b}, {c}");
    }
  }
}
