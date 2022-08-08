using System; 

public class Program {
  public static double AreaCirculo(double raio) {
    return 3.14 * raio * raio;
  }

  public static void Main(string[] args) {
    double n1 = double.Parse(Console.ReadLine());
    Console.WriteLine(AreaCirculo(n1));
    
  }
}
