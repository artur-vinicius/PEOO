using System; 

public class Program {
  public static int MenorInteiro(double x) {
    return (int)(Math.Ceiling(x));
  }

  public static void Main(string[] args) {
    double n1 = double.Parse(Console.ReadLine());
    Console.WriteLine(MenorInteiro(n1));
  }
}
